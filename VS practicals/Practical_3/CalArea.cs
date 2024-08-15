using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public class CalArea
    {
        public double Area(double side)
        {
            return side * side; // Area of Square
        }

        public double Area(double length, double width)
        {
            return length * width; // Area of Rectangle
        }

        public double Area(int radius)
        {
            return 3.14 * radius * radius; // Area of Circle
        }
    }
}
