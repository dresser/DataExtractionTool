﻿using System;
using System.Linq;
using DataExtractionTool.Extensions;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class GetSiteTree : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = args as DownloadDataArgs;
            var home = new Node { Name = "<Home>", Url = new Uri(downloadArgs.Urls.First().GetSchemeAndHost()) };
            foreach (var url in downloadArgs.Urls)
            {
                AddPath(home, url);
            }
            downloadArgs.SiteTree = home;
        }

        private static string StripExtension(string nodeName)
        {
            if (nodeName.Contains("."))
            {
                var i = nodeName.LastIndexOf(".");
                return nodeName.Substring(0, i);
            }
            return nodeName;
        }

        private void AddPath(Node current, Uri url)
        {
            char[] charSeparators = new char[] { '/' };

            string[] parts = url.PathAndQuery.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            var cur = current;
            for (int i = 0; i < parts.Length; i++)
            {
                var lastPart = i == parts.Length - 1;
                var part = lastPart ? StripExtension(parts[i]) : parts[i];
                Node child;
                if (!cur.Children.TryGetValue(part, out child))
                {
                    child = new Node
                    {
                        Name = part,
                        Parent = cur
                    };
                    cur.Children[part] = child;
                }
                if (lastPart)
                {
                    child.Url = url;
                }
                cur = child;
            }
        }
    }
}
