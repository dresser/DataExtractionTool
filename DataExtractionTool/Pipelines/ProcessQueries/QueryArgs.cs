using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class QueryArgs : PipelineArgs
    {
        public Node SiteTree { get; set; }
        public IEnumerable<Document> Documents { get; set; }
    }
}
