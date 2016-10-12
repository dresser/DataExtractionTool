using System;

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
            var sitemapUriString = args[0];
            Uri sitemapUri;
            if(!Uri.TryCreate(sitemapUriString, UriKind.Absolute, out sitemapUri))
            {
                Console.WriteLine("Invalid sitemap XML URL");
                Console.Read();
                return;
            }

            var workingFolder = args[1];
            var siteFolder = workingFolder + @"\" + sitemapUri.Host;
            var pipelineArgs = new Pipelines.DownloadData.PipelineArgs
            {
                SitemapUrl = sitemapUri,
                SiteFolder = siteFolder,
                Overwrite = false
            };

            var pipeline = new Pipelines.DownloadData.DownloadDataPipeline();
            pipeline.Run(pipelineArgs);
        }
    }
}
