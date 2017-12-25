using DataExtractionTool.Pipelines.DownloadData;
using System;
using DataExtractionTool.Pipelines.ProcessQueries;

namespace DataExtractionTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null
                || args.Length < 2)
            {
                Console.WriteLine("Invalid arguments");
                Console.Read();
                return;
            }

            ActionBase action;
            if (DownloadAction.ContainsCommandSwitch(args))
            {
                action = new DownloadAction(args);
                var downloadAction = (DownloadAction) action;
                if (action.Valid)
                {
                    var pipelineArgs = new DownloadDataArgs
                    {
                        SitemapUrl = downloadAction.SitemapUri,
                        SiteFolder = downloadAction.SiteFolder,
                        Overwrite = false
                    };

                    var pipeline = new DownloadDataPipeline();
                    pipeline.Run(pipelineArgs);
                    pipelineArgs.Errors.ForEach(e => Console.WriteLine(e));
                }
                action.Errors.ForEach(e => Console.WriteLine(e));
            }

            if (ProcessAction.ContainsCommandSwitch(args))
            {
                action = new ProcessAction(args);
                var processAction = (ProcessAction) action;
                if (action.Valid)
                {
                    var processQueriesArgs = new QueryArgs
                    {
                        MetaDataFile = processAction.MetaDataFile
                    };

                    var pipeline = new ProcessQueriesPipeline();
                    pipeline.Run(processQueriesArgs);
                    processQueriesArgs.Errors.ForEach(e => Console.WriteLine(e));
                }
                action.Errors.ForEach(e => Console.WriteLine(e));
            }

            Console.ReadKey();
        }
    }
}
