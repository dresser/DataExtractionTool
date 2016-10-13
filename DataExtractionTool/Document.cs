using AngleSharp.Dom.Html;
using System;

namespace DataExtractionTool
{
    public class Document
    {
        public string Html { get; set; }
        public Uri Url { get; set; }
        public string FileName { get; set; }
        public IHtmlDocument HtmlDocument { get; set; }
    }
}
