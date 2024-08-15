using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    interface CalculateInterface
    {
        public int Addition(int a, int b);
        public int Subtraction(int a, int b);

    }
    public class Result : CalculateInterface
    {
        public int Addition(int a, int b)
        {
            return (a + b);
        }

        public int Subtraction(int a, int b)
        {
            return (a - b);
        }
    }
}
