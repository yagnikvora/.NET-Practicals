using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Staff
    {
        public string Name, Department, Designation;
        public double Experience;
        public int Salary;

        public void getData()
        {
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Department : ");
            Department = Console.ReadLine();
            Console.Write("Enter Designation : ");
            Designation = Console.ReadLine();
            Console.Write("Enter Experience : ");
            Experience = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Salary : ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name : {0} Salary : {1}",Name,Salary);
        }
    }
}
