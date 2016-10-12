namespace DataExtractionTool.Pipelines.DownloadData
{
    public class DownloadDataPipeline
    {
        private ProcessorBase[] _pipelineProcessors = new ProcessorBase[] {
            new GetPageUrls(),
            new GetSiteTree(),
            new CreateWorkingFolder(),
            new DownloadNodes()
        };

        public void Run(PipelineArgs args)
        {
            for (int i = 0; i < _pipelineProcessors.Length; i++)
            {
                _pipelineProcessors[i].Process(args);
            }
        }
    }
}
