using System.Collections.Generic;
using DataExtractionTool.Core.Query;

namespace DataExtractionTool.Core.Pipelines.ProcessQueries
{
    public class QueryArgs : PipelineArgs
    {
        public string MetaDataFile { get; set; }
        public IEnumerable<WebPage> WebPages { get; set; }
        public QueryInfo Query { get; set; }
    }
}
