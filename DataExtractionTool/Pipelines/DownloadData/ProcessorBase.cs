namespace DataExtractionTool.Pipelines.DownloadData
{
    public abstract class ProcessorBase
    {
        public abstract void Process(PipelineArgs args);
    }
}
