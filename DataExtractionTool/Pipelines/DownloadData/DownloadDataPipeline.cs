namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataPipeline : Pipeline
    {
        protected override PipelineProcessor[] PipelineProcessors => new PipelineProcessor[]
        {
            new GetPageUrlsFromSitemap(),
            new CreateWorkingFolder(),
            new DownloadWebPages(),
            new WriteMetaData()
        };

        public void Run(DownloadDataArgs args)
        {
            base.Run(args);
        }
    }
}
