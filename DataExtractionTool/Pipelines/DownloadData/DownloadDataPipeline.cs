namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataPipeline : Pipeline
    {
        protected override PipelineProcessor[] PipelineProcessors
        {
            get
            {
                return new PipelineProcessor[] {
                    new GetPageUrls(),
                    new GetSiteTree(),
                    new CreateWorkingFolder(),
                    new DownloadNodes()
                };
            }
        }

        public void Run(DownloadDataArgs args)
        {
            base.Run(args);
        }
    }
}
