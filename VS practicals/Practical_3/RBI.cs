using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public class RBI
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("Calculating interest in RBI");
        }
    }public class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculating interest in HDFC");
        }
    }public class SBI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculating interest in SBI");
        }
    }public class ICICI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculating interest in ICICI");
        }
    }
}
