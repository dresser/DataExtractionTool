using System.Collections.Generic;
using System.Linq;

namespace DataExtractionTool.Core
{
    public class ProcessAction : ActionBase
    {
        public string MetaDataFile { get; set; }

        public static string[] GetCommandSwitches()
        {
            return new[] { "-process", "-p" };
        }

        public ProcessAction(string[] args)
        {
            Errors = new List<string>();
            if (args == null
                || args.Length < 2)
            {
                Errors.Add("Invalid arguments");
                return;
            }
            MetaDataFile = args[1];
            if (!System.IO.File.Exists(MetaDataFile))
            {
                Errors.Add("MetaDataFile not found");
            }
        }

        public static bool ContainsCommandSwitch(string[] args)
        {
            return args != null &&
                   args.Length > 0 &&
                   GetCommandSwitches().Contains(args[0]);
        }
    }
}
