using System;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class ProcessQueriesPipeline : Pipeline
    {
        protected override PipelineProcessor[] PipelineProcessors
        {
            get
            {
                return new PipelineProcessor[]
                {
                    new ParseDocuments(),
                    new RunQueries()
                };
            }
        }
    }
}
