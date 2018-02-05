using System.Collections.Generic;
using System.Linq;

namespace DataExtractionTool.Core
{
    public abstract class ActionBase
    {
        public List<string> Errors { get; set; }
        public bool Valid => !Errors.Any();
    }
}
