﻿using DataExtractionTool.Pipelines.DownloadData;
using System;
using Xunit;
using System.Xml.XPath;

namespace DataExtractionTool.Tests.Pipelines.DownloadData
{
    public class WriteMetaDataTests
    {
        [Fact]
        public void BuildMetaDataDocument_Success()
        {
            var writeMetaData = new WriteMetaData();
            var pages = new[]
            {
                new WebPage { FileName="1.html", Url=new Uri("http://test.com/1.html") }
            };
            var result = writeMetaData.BuildMetaDataDocument(pages);
            Assert.NotNull(result);
            Assert.Single(result.Document.XPathSelectElements("urls/page"));
        }
    }
}
