using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_4
{
    public class A2
    {
        public void perform()
        {
            List<string> StudentName = new List<string>();
            Console.WriteLine("---------Add()--------");

            StudentName.Add("Yagnik");
            StudentName.Add("Ronak");
            StudentName.Add("Umang");
            StudentName.Add("Vansh");
            StudentName.Add("Raj");

            foreach (var a in StudentName)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------Remove(\"Ronak\")----------");
            StudentName.Remove("Ronak");
            foreach (var a in StudentName)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------RemoveRange(1,2)--------");
            StudentName.RemoveRange(1, 2);
            foreach (var a in StudentName)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------Clear()--------");
            StudentName.Clear();
            foreach (var a in StudentName)
            {
                Console.WriteLine(a);
            }
        }
    }
}
