using DataExtractionTool.Pipelines.DownloadData;
using System;
using System.Linq;
using Xunit;

namespace DataExtractionTool.Tests.Pipelines.DownloadData
{
    public class DownloadWebPagesTests
    {
        [Fact]
        public void DownloadPage_Success()
        {
            var downloadWebPages = new DownloadWebPages();
            var args = new DownloadDataArgs { };
            var page = new WebPage { Url = new Uri("http://test.com") };
            Assert.Null(page.FileName);
            Assert.Null(page.Html);
            downloadWebPages.DownloadPage(args, page);
            Assert.NotNull(page.FileName);
            Assert.NotNull(page.Html);
        }

        [Fact]
        public void Process_Success()
        {
            var pages = new[]
                {
                    new WebPage { Url = new Uri("http://test.com") },
                    new WebPage { Url = new Uri("http://test.com/1") },
                    new WebPage { Url = new Uri("http://test.com/2") }
                };
            var args = new DownloadDataArgs { WebPages = pages };
            Assert.Empty(args.WebPages.Where(p => p.Html != null));
            var downloadWebPages = new DownloadWebPages();
            downloadWebPages.Process(args);
            Assert.NotEmpty(args.WebPages.Where(p => p.Html != null));
        }
    }
}
