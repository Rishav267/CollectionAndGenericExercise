using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("string1");
            queue.Enqueue("string2");
            queue.Enqueue("string4");
            queue.Enqueue("string5");

            foreach(var obj in queue)
            {
                Console.WriteLine(obj);
            }

            Queue<string> NewQueue = new Queue<string>();

            while(queue.Count !=0)
            {
                NewQueue.Enqueue(queue.Dequeue());
                if(queue.Count!=0 && queue.Peek() == "string2")
                {
                    NewQueue.Enqueue(queue.Dequeue());
                    NewQueue.Enqueue("string3");
                }
            }
            foreach (var obj in NewQueue)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
