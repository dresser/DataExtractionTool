using System;
using System.Collections.Generic;

namespace DataExtractionTool
{
    public class Node
    {
        public string Name { get; set; }
        public Uri Url { get; set; }
        public Node Parent { get; set; }
        public readonly IDictionary<string, Node> Children = new Dictionary<string, Node>();
        public bool IsPage { get { return Url != null; } }
        public bool IsRoot { get { return Parent == null; } }

        public string GetPath()
        {
            return GetPath(this, "/");
        }

        private string GetPath(Node node, string pathSeparator)
        {
            if (node == null || node.IsRoot)
            {
                return null;
            }
            return (node.Parent != null ? GetPath(node.Parent, pathSeparator) : (string)null)
                    + pathSeparator
                    + node.Name;
        }
    }
}
