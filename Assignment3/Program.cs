using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("string1");
            stack1.Push("string2");
            stack1.Push("string4");
            stack1.Push("string5");

            foreach(var v in stack1)
            {
                Console.WriteLine(v);
            }

            Stack<string> newStack = new Stack<string>();

            while(stack1.Count>0)
            {
                
                if(stack1.Count != 0 && stack1.Peek() == "string4")
                {
                    newStack.Push(stack1.Pop());
                    newStack.Push("string3");
                }
                else
                    newStack.Push(stack1.Pop());
            }
            foreach (var v in newStack)
            {
                Console.WriteLine(v);
            }
        }
    }
}
