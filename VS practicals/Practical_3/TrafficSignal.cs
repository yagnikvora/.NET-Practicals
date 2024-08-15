using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public delegate void TrafficDel();

    public class TrafficSignal
    {
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal");
        }
        public static void Green()
        {
            Console.WriteLine("Green Light Signal");
        }
        public static void Red()
        {
            Console.WriteLine("Red Light Signal");
        }
    }

}
