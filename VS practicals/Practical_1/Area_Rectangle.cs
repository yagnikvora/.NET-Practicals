using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Area_Rectangle
    {
        public double area;

        public Area_Rectangle(double l, double w) 
        {
            area = l * w;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area of Ractangle is " + area);
        }
    }
}
