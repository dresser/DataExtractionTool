using System.IO;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class CreateWorkingFolder : ProcessorBase
    {
        public override void Process(PipelineArgs args)
        {
            if (!Directory.Exists(args.SiteFolder))
            {
                Directory.CreateDirectory(args.SiteFolder);
            }
        }
    }
}
