﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using DataExtractionTool.Core.Extensions;

namespace DataExtractionTool.Core.Pipelines.DownloadData
{
    public class GetPageUrlsFromSitemap : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = (DownloadDataArgs) args;
            downloadArgs.WebPages = GetSitemapPageUrls(downloadArgs.SitemapUrl)
                .Take(100) //temp debugging measure
                .Select(url => new WebPage
                {
                    Url = url
                })
                .ToList();
        }

        private IList<Uri> GetSitemapPageUrls(Uri sitemapUrl)
        {
            var xdoc = XDocument.Load(sitemapUrl.AbsoluteUri);

            var namespaceManager = new System.Xml.XmlNamespaceManager(new NameTable());
            namespaceManager.AddNamespace("empty", "http://www.sitemaps.org/schemas/sitemap/0.9");

            var locs = xdoc.XPathSelectElements("empty:urlset/empty:url/empty:loc", namespaceManager);
            var rootUrl = sitemapUrl.GetSchemeAndHost();
            return locs.OrderBy(u => u.Value)
                    .Select(l => new Uri(l.Value))
                    .ToList();
        }
    }
}
