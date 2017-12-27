using System;
using System.IO;
using System.Net;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadWebPages : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = args as DownloadDataArgs;
            for (int i = 0; i < downloadArgs.WebPages.Count; i++)
            {
                DownloadPage(downloadArgs, downloadArgs.WebPages[i]);
            }
        }

        public void DownloadPage(DownloadDataArgs downloadArgs, WebPage page)
        {
            var html = DownloadString(page.Url);
            var fileName = downloadArgs.SiteFolder
                            + @"\" + Guid.NewGuid().ToString("N")
                            + ".html";
            WriteToFile(fileName, html);
            page.Html = html;
            page.FileName = fileName;
        }

        public string DownloadString(Uri url)
        {
            using (var client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }

        public void WriteToFile(string fileName, string content)
        {
            var file = new FileInfo(fileName);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            File.WriteAllText(fileName, content);
        }
    }
}
