using System;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class ProcessQueriesPipeline : Pipeline
    {
        protected override PipelineProcessor[] PipelineProcessors => new PipelineProcessor[]
        {
            new ReadMetaData(),
            new ParseDocuments(),
            new RunQueries()
        };

        public void Run(QueryArgs args)
        {
            base.Run(args);
        }
    }
}
