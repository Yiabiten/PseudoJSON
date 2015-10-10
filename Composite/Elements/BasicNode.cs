using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Elements
{
    public class BasicNode : Node
    {
        protected readonly string val;

        public BasicNode(string k, string v)
            : base(k)
        {
            val = v;
        }

        #region equlas / hashCode
        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var o = (BasicNode)obj;
            return key.Equals(o.key) && val.Equals(o.val);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return key.GetHashCode() * 17 + val.GetHashCode();
        }
        #endregion

        public override string Print(int depth = 0)
        {
            base.Print(depth);
            var prefix = new string(indentationChar, depth);
            return string.Format("{0}{1} : {2}\n", prefix, key, val);
        }
    }
   
    
}
