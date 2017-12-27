using DataExtractionTool.Query;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class QueryArgs : PipelineArgs
    {
        public string MetaDataFile { get; set; }
        public IEnumerable<WebPage> WebPages { get; set; }
        public QueryInfo Query { get; set; }
    }
}
