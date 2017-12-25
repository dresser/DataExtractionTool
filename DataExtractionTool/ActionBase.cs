using System;
using System.Collections.Generic;
using System.Linq;

namespace DataExtractionTool
{
    public abstract class ActionBase
    {
        public List<string> Errors { get; set; }
        public bool Valid => !Errors.Any();
    }
}
