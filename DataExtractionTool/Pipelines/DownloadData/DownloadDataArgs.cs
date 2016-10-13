using System;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataArgs : PipelineArgs
    {
        public Uri SitemapUrl { get; set; }
        public IEnumerable<Uri> Urls { get; set; }
        public string SiteFolder { get; set; }
        public bool Overwrite { get; set; }
        public Node SiteTree { get; set; }
    }
}
