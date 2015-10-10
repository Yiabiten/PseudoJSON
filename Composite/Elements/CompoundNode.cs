using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Elements
{
    public class CompoundNode : Node
    {
        List<Node> childs = new List<Node>();

        public CompoundNode(string k) : base(k) { }

        #region equlas / hashCode
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var o = (CompoundNode)obj;
            if (childs.Count != o.childs.Count || !key.Equals(o.key))
            {
                return false;
            }
            for (int i = 0; i < childs.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < childs.Count; j++)
                {
                    if (childs[i].key.Equals(o.childs[j].key))
                    {
                        found = true;
                        if (!childs[i].Equals(o.childs[j]))
                        {
                            return false;
                        }
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }
            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            int all = 0;
            for (int i = 0; i < childs.Count; i++)
            {
                all += childs[i].GetHashCode();
            }
            return all;
        }
        #endregion

        public override string Print(int depth = 0)
        {
            base.Print(depth);
            var prefix = new string(indentationChar, depth);
            var sb = new StringBuilder();
            sb.AppendFormat("{0}{1} {{\n", prefix, key);
            for (int i = 0; i < childs.Count; i++)
            {
                sb.Append(childs[i].Print(depth + 1));
            }
            return sb + prefix + "}\n";
        }

        public void Add(Node elt)
        {
            if (elt == null) throw new ArgumentException("Sorry, Can't take Null values !");
            childs.Add(elt);
        }
    }
}
