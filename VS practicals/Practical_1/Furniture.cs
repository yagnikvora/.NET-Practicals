using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_1
{
    public class Furniture
    {
        public string Material;
        public double Price;

        public void GetData()
        {
            Console.Write("Enter Name of Matrial :");
            this.Material = Console.ReadLine();
            Console.Write("Enter Price : ");
            this.Price = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowData() 
        { 
            Console.WriteLine("Material : " + Material); 
            Console.WriteLine("Price : " + Price); 
        }
    }

    public class Table : Furniture
    {
        public double Height, surface_area;

        public void GetData()
        {
            base.GetData();
            Console.Write("Enter Height of Table : ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Surface Area of Table : ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Surface Area : " + surface_area);
        }
    }
}
