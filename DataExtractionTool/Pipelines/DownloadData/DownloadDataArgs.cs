using System;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataArgs : PipelineArgs
    {
        private const string MetaDataFolderName = "MetaData";
        private const string MetaDataFileName = "Pages.xml";
        public Uri SitemapUrl { get; set; }
        public IList<WebPage> WebPages { get; set; }
        public string SiteFolder { get; set; }
        public string MetaDataFolder { get { return SiteFolder + @"\" + MetaDataFolderName; } }
        public string MetaDataFile { get { return MetaDataFolder + @"\" + MetaDataFileName; } }
        public bool Overwrite { get; set; }
    }
}
