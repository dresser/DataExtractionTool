using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DataExtractionTool.Core.Pipelines.ProcessQueries
{
    public class ReadMetaData : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var queryArgs = args as QueryArgs;
            var xdoc = XDocument.Load(queryArgs.MetaDataFile);
            var rootUrl = xdoc.XPathSelectElement("urls")?.Attribute("rootUrl")?.Value;
            var pages = xdoc.XPathSelectElements("urls/page");
            queryArgs.WebPages = pages.Select(p => new WebPage
                {
                    FileName = p?.XPathSelectElement("fileName")?.Value,
                    Url = new Uri(rootUrl + p?.XPathSelectElement("url")?.Value)
                })
                .ToList();
        }
    }
}
