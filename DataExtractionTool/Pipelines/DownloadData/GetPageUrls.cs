using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using DataExtractionTool.Extensions;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class GetPageUrls : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = args as DownloadDataArgs;
            downloadArgs.WebPages = GetSitemapPageUrls(downloadArgs.SitemapUrl)
                .Take(5) //temp debugging measure
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
