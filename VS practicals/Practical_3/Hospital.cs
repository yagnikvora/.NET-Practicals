using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("General Hospital Details");
        }
    }

    public class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital Details");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital Details");
        }
    }

    public class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality Hospital Details");
        }
    }
}
