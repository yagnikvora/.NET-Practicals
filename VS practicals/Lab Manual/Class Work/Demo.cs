using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Class_Work
{
    public class Demo
    {
        public Demo()
        {
            Console.WriteLine("This is Default Cunstructor");
        }
        public Demo(string name)
        {
            Console.WriteLine($"Name : {name}");

        }
        public Demo(Demo d1)
        {
            Console.WriteLine($"Copy Constructor");
        }
    }
}
