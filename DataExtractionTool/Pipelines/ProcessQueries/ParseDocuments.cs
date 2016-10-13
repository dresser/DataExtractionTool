using AngleSharp.Parser.Html;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class ParseDocuments : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var queryArgs = args as QueryArgs;
            foreach(var page in queryArgs.WebPages)
            {
                ParseWebPage(page);
            }
        }

        public void ParseWebPage(WebPage webPage)
        {
            var parser = new HtmlParser();
            webPage.HtmlDocument = parser.Parse(webPage.Html);
        }
    }
}
