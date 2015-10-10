using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Elements
{
    public abstract class Node
    {
        public string key { get; private set; }
        public const char indentationChar = '-';

        public Node(string k)
        {
            key = k;
        }

        public virtual string Print(int depth)
        {
            if (depth < 0) throw new ArgumentException("Sorry, Can't take negitve values !");
            return "";
        }
    }
    
}
