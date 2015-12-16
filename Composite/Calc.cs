using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Calc
    {
        public static double Moy(int[] tab)
        {
            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum += tab[i];
            }
            return sum /(double) tab.Length;
        }

    }
}
