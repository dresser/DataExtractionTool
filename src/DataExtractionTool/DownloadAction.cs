using System;
using System.Collections.Generic;
using System.Linq;

namespace DataExtractionTool
{
    public class DownloadAction : ActionBase
    {
        public static string[] GetCommandSwitches()
        {
            return new[] {"-download", "-d"};
        }

        public Uri SitemapUri { get; set; }
        public string SiteFolder { get; set; }

        public DownloadAction(string[] args)
        {
            Errors = new List<string>();
            if (args == null
                || args.Length < 3)
            {
                Errors.Add("Invalid arguments");
            }
            var sitemapUriString = args[1];
            if (!Uri.TryCreate(sitemapUriString, UriKind.Absolute, out var sitemapUri))
            {
                Errors.Add("Invalid sitemap XML URL");
            }
            SitemapUri = sitemapUri;
            var workingFolder = args[2];
            if (!System.IO.Directory.Exists(workingFolder))
            {
                Errors.Add("Invalid working folder.");
            }
            SiteFolder = workingFolder + @"\" + sitemapUri.Host;
        }

        public static bool ContainsCommandSwitch(string[] args)
        {
            return args != null &&
                   args.Length > 0 &&
                   GetCommandSwitches().Contains(args[0]);
        }
    }
}
