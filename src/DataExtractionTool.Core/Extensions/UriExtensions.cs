using System;

namespace DataExtractionTool.Core.Extensions
{
    public static class UriExtensions
    {
        public static string GetSchemeAndHost(this Uri uri)
        {
            return uri.GetLeftPart(UriPartial.Authority);
        }
    }
}
