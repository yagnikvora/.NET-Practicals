using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Programe.Practical_4
{
    public class B4
    {
        public void perform()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);
            Console.WriteLine("-------Enqueue()----------");

            foreach (var a in q)
            {
                Console.WriteLine(a);
            }
            q.Dequeue();
            Console.WriteLine("-------Dequeue()----------");
            foreach (var a in q)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------Peek()----------");
            Console.WriteLine(q.Peek());
            Console.WriteLine("-------Contains(30)----------");
            Console.WriteLine(q.Contains(30));
            Console.WriteLine("-------Clear()----------");
            q.Clear();
            foreach (var a in q)
            {
                Console.WriteLine(a);
            }
        }
    }
}
