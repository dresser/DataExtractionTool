using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class WriteMetaData : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = args as DownloadDataArgs;
            var xmlDoc = BuildMetaDataDocument(downloadArgs.WebPages.Where(wp => wp.FileName != null));
            xmlDoc.Save(downloadArgs.MetaDataFile);
        }

        public XDocument BuildMetaDataDocument(IEnumerable<WebPage> webPages)
        {
            return new XDocument(
                            new XElement("urls",
                                webPages.Select(p =>
                                    new XElement("page",
                                        new XElement("url", p.Url.AbsolutePath),
                                        new XElement("fileName", p.FileName)))));
        }
    }
}
