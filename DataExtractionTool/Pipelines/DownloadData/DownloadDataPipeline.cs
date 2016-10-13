﻿namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataPipeline : Pipeline
    {
        protected override PipelineProcessor[] PipelineProcessors
        {
            get
            {
                return new PipelineProcessor[] 
                {
                    new GetPageUrls(),
                    new CreateWorkingFolder(),
                    new DownloadWebPages(),
                    new WriteMetaData()
                };
            }
        }

        public void Run(DownloadDataArgs args)
        {
            base.Run(args);
        }
    }
}
