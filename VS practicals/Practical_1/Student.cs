using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Student
    {
        public long EnrollmentNo, Sem; 
        public string StudentName; 
        public double CPI, SPI; 
        public Student() 
        { 
            Console.Write("Enter Enrollment Number : "); 
            EnrollmentNo = Convert.ToInt64(Console.ReadLine()); 
            Console.Write("Enter Student's Name : ");
            StudentName = Console.ReadLine();
            Console.Write("Enter Sem : ");
            Sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter CPI : ");
            CPI = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter SPI : ");
            SPI = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollment Number : "+ EnrollmentNo);
            Console.WriteLine("Student Name : "+ StudentName);
            Console.WriteLine("Semester : "+ Sem);
            Console.WriteLine("CPI  : "+ CPI);
            Console.WriteLine("SPI  : "+ SPI);
        }
    }
}
