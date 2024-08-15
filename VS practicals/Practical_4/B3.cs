using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_4
{
    public class B3
    {
        public void perform()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);
            Console.WriteLine("-------Push()----------");

            foreach (var a in st)
            {
                Console.WriteLine(a);
            }
            st.Pop();
            Console.WriteLine("-------Pop()----------");

            foreach (var a in st)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------Peek()----------");
            Console.WriteLine(st.Peek());
            Console.WriteLine("-------Contains(30)----------");
            Console.WriteLine(st.Contains(30));
            Console.WriteLine("-------Clear()----------");
            st.Clear();
            foreach (var a in st)
            {
                Console.WriteLine(a);
            }
        }
    }
}
