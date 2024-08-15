using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Bank_Account
    {
        public int AccountNo; 
        public string Email, UserName, AccountType; 
        public double AccountBalance; 
        public void GetAccountDetails() 
        { 
            Console.Write("Enter Account number : ");
            AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email : "); 
            Email = Console.ReadLine(); 
            Console.Write("Enter Username : "); 
            UserName = Console.ReadLine(); 
            Console.Write("Enter Account type : "); 
            AccountType = Console.ReadLine(); 
            Console.Write("Enter Account balance : "); 
            AccountBalance = Convert.ToDouble(Console.ReadLine()); 
        }
        public void DisplayAccountDetails() 
        { 
            Console.WriteLine("Account number : "+AccountNo); 
            Console.WriteLine("Email : "+Email); 
            Console.WriteLine("Username : "+UserName); 
            Console.WriteLine("Account type : "+AccountType); 
            Console.WriteLine("Account balance : "+AccountBalance); 
        }
    }
}
