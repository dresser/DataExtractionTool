using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractionTool
{
    public class Document
    {
        public string Html { get; set; }
        public Uri Url { get; set; }
        public string FileName { get; set; }
    }
}
