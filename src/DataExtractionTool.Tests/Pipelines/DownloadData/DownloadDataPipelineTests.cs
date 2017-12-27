using DataExtractionTool.Pipelines.DownloadData;
using System;
using System.Linq;
using Xunit;

namespace DataExtractionTool.Tests.Pipelines.DownloadData
{
    public class DownloadDataPipelineTests
    {
        [Fact]
        public void DownloadWebPagesAndWriteMetaData_Success()
        {
            var pages = new[]
                {
                    new WebPage { Url = new Uri("http://test.com") },
                    new WebPage { Url = new Uri("http://test.com/1") },
                    new WebPage { Url = new Uri("http://test.com/2") }
                };
            var args = new DownloadDataArgs { WebPages = pages };
            Assert.Empty(args.WebPages.Where(p => p.Html != null));
            var step1 = new DownloadWebPages();
            step1.Process(args);
            var step2 = new WriteMetaData();
            step2.Process(args);
            Assert.NotEmpty(args.WebPages.Where(p => p.Html != null));
        }

        [Fact]
        public void DownloadData_Success()
        {
            var pipeline = new DownloadDataPipeline();
            var args = new DownloadDataArgs
            {
                Overwrite = true,
                SiteFolder = @"C:\Projects\WebSpider",
                SitemapUrl = new Uri(@"http://www.loreal-paris.fr/sitemap.xml")
            };
            pipeline.Run(args);

        }
    }
}
