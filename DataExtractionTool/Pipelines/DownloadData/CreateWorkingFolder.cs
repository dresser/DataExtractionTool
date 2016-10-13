using System.IO;

namespace DataExtractionTool.Pipelines.DownloadData
{
    public class CreateWorkingFolder : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = args as DownloadDataArgs;
            if (!Directory.Exists(downloadArgs.SiteFolder))
            {
                Directory.CreateDirectory(downloadArgs.SiteFolder);
            }
            if (!Directory.Exists(downloadArgs.MetaDataFolder))
            {
                Directory.CreateDirectory(downloadArgs.MetaDataFolder);
            }
        }
    }
}
