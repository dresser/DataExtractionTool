using DataExtractionTool.Query;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class QueryArgs : PipelineArgs
    {
        public IEnumerable<WebPage> WebPages { get; set; }
        public QueryInfo Query { get; set; }
    }
}
