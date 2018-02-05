using System.IO;

namespace DataExtractionTool.Core.Pipelines.DownloadData
{
    public class CreateWorkingFolder : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var downloadArgs = (DownloadDataArgs) args;
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
