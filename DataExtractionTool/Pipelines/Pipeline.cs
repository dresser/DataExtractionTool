namespace DataExtractionTool.Pipelines
{
    public abstract class Pipeline
    {
        protected abstract PipelineProcessor[] PipelineProcessors { get; }

        protected void Run(PipelineArgs args)
        {
            for (int i = 0; i < PipelineProcessors.Length; i++)
            {
                PipelineProcessors[i].Process(args);
            }
        }
    }
}
