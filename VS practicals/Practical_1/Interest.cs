using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Account_Details
    {
        public long Account_no;
        public string Name;
        public double p, r, n;

        public void GetDetails()
        {
            Console.Write("Enter Account No : ");
            Account_no = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Account Name : ");
            Name = Console.ReadLine(); 
            Console.Write("Enter Principal Amount : ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Rate : ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Duration : ");
            n = Convert.ToDouble(Console.ReadLine());
        }
    }
    public class Interest: Account_Details
    {
        public Interest()
        {
            GetDetails();
        }
        public void CalculateInterest()
        {
            Console.WriteLine("Interest = " + ((p * r * n) / 100));
        }
    }
}
