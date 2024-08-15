using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Salary
    {
        public double TA, DA, HRA, Basic, Total;
        public Salary()
        {
            DA = 2000;
            HRA = 7000;

            Console.Write("Enter TA : ");
            this.TA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Basic Salary : ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
            this.Total = TA + DA + HRA + Basic;
        }
        public void DisplaySalary()
        {
            Console.WriteLine();
            Console.WriteLine("TA : " + TA);
            Console.WriteLine("DA : " + DA);
            Console.WriteLine("HRA : " + HRA);
            Console.WriteLine("Basic Salary : " + Basic);
            Console.WriteLine("Total Salary : " + Total);
        }
    }
}
