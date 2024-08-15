using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    interface Gross
    {
        public double Gross_Salary();
    }
    public class Employee
    {
        public string Name;
        public double BasicSalary;

        public void Basic_Salary()
        {
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Basic Salary : ");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
        }
    }
    public class SalaryOfEmployee : Employee, Gross
    {
        public double HRA, TA, DA;
        public SalaryOfEmployee()
        {
            Basic_Salary(); 
            Console.Write("Enter TA: "); 
            TA = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Enter DA: "); 
            DA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter HRA: "); 
            HRA = Convert.ToDouble(Console.ReadLine());
        }

        public double Gross_Salary()
        {
            return (BasicSalary + HRA + TA + DA);
        }

        public void PrintSalary()
        {
            Console.WriteLine("Gross Salary = " + Gross_Salary());
        }
    }
}
