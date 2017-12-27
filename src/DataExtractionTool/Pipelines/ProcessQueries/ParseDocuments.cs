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
                ParseWebPage(args, page);
            }
        }

        public void ParseWebPage(PipelineArgs args, WebPage webPage)
        {
            var parser = new HtmlParser();
            if (!System.IO.File.Exists(webPage.FileName))
            {
                args.Errors.Add($"File {webPage.FileName} not found.");
                return;
            }

            webPage.Html = System.IO.File.ReadAllText(webPage.FileName);
            webPage.HtmlDocument = parser.Parse(webPage.Html);
        }
    }
}
