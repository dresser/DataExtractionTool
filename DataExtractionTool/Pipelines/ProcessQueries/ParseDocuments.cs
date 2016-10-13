using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;

namespace DataExtractionTool.Pipelines.ProcessQueries
{
    public class ParseDocuments : PipelineProcessor
    {
        public override void Process(PipelineArgs args)
        {
            var queryArgs = args as QueryArgs;

            throw new NotImplementedException();
        }

        private void ReadNode(Node node, IList<Document> documents)
        {
            var parser = new HtmlParser();
            documents.Add(new Document {
                //HtmlDocument = parser.Parse(node.)
            }); 
        }
    }
}
