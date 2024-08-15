using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public delegate int CalculateFact(int n);
    public class FactDelegate
    {
        
        public CalculateFact factorial = CalFact;
        public static int CalFact(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * CalFact(n - 1));
        }

    }
}
