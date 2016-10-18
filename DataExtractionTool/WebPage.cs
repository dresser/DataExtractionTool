using AngleSharp.Dom.Html;
using System;

namespace DataExtractionTool
{
    public class WebPage
    {
        public string Html { get; set; }
        public Uri Url { get; set; }
        public string FileName { get; set; }
        public IHtmlDocument HtmlDocument { get; set; }

        public override string ToString()
        {
            return "{Url=" + Url.AbsoluteUri + ", FileName=" + FileName + "}";
        }
    }
}
