using System;

namespace DataExtractionTool
{
    public class CustomUri : Uri
    {
        public CustomUri(string uriString) : base(uriString) { }
        private string _schemeAndHost;
        public string SchemeAndHost
        {
            get
            {
                if (_schemeAndHost == null)
                {
                    _schemeAndHost = this.GetLeftPart(UriPartial.Authority);
                }
                return _schemeAndHost;
            }
        }
    }
}
