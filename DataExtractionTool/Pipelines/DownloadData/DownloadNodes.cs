﻿using System.Net;
using System.IO;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadNodes : ProcessorBase
    {
        public override void Process(PipelineArgs args)
        {
            DownloadNode(args.SiteFolder, args.SiteTree, args.Overwrite);
        }

        public void DownloadNode(string rootPath, Node node, bool overwrite)
        {
            var fileName = rootPath + @"\" + (node.IsRoot ? "(home)" : node.Name) + ".html";
            var content = "";
            if (node.IsPage)
            {
                var exists = System.IO.File.Exists(fileName);
                if (!exists
                    || (exists && overwrite))
                {
                    content = DownloadString(node.Url);
                    WriteToFile(fileName, content);
                }
            }
            if (node.Children != null)
            {
                var directory = rootPath + (!node.IsRoot ? @"\" + node.Name : "");
                if (!node.IsRoot
                    && !node.IsPage
                    && !System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }
                foreach (var child in node.Children)
                {
                    DownloadNode(directory, child.Value, overwrite);
                }
            }
        }

        public void WriteToFile(string fileName, string content)
        {
            var file = new FileInfo(fileName);
            if(!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            System.IO.File.WriteAllText(fileName, content);
        }

        public string DownloadString(CustomUri url)
        {
            using (var client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}