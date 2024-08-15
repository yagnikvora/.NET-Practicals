using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Candidate
    {
        public int ID;
        public string Name;
        public double age,weight,height;

        public void GetCandidateDetails()
        {
            Console.Write("Eneter ID : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eneter Name : ");
            Name = Console.ReadLine();
            Console.Write("Eneter Age : ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eneter Weight : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eneter Height : ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("------Candidate Details------");
            Console.WriteLine("ID : "+ID);
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Age : "+age);
            Console.WriteLine("Weight : "+weight);
            Console.WriteLine("Height : "+height);
        }
    }
}
