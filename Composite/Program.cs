using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Composite.Elements;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            var rt = new CompoundNode("root");
            for (int i = 0; i < 5; i++)
            {
                var elt = new BasicNode("elt" + (i + 1), "val" + (i + 1));
                rt.Add(elt);
            }
            var rtt = new CompoundNode("sub");
            for (int i = 0; i < 5; i++)
            {
                var elt = new BasicNode("eltSub" + (i + 1), "valSub" + (i + 1));
                rtt.Add(elt);
            }

            rt.Add(rtt);
            Console.WriteLine(rt.Print(-41))//;
            Console.ReadKey();
        }
    }

    
    
}

/*               ______________
                |     Node    |_____________
                |______________|             |
                       ^                     |
                      /_\                    |
          _____________|_______              |
    ______|_______       ______|_______      |
   |    Basic     |     |   Compound   |/\___|
   |______________|     |______________|\/
 
 */