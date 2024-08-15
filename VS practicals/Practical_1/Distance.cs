using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Distance
    {
        public double d1,d2,d3;
        
        public Distance(double dist1,double dist2)
        {
            this.d1 = dist1;
            this.d2 = dist2;
        }
        public void AddDistance()
        {
            this.d3 = this.d1 + this.d2;
        }
        public void DisplaySum()
        {
            Console.WriteLine("Addition of two Distance = " + this.d3);
        }
    }
}
