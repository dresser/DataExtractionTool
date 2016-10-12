using System;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class PipelineArgs
    {
        public Uri SitemapUrl { get; set; }
        public IEnumerable<CustomUri> Urls { get; set; }
        public string SiteFolder { get; set; }
        public bool Overwrite { get; set; }
        public Node SiteTree { get; set; }
    }
}
