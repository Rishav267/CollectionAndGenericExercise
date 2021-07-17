using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            ClsPerson person1 = new ClsPerson("John");
            ClsPerson person2 = new ClsPerson("Sam");
            ClsPerson person3 = new ClsPerson("Pooja");

            array.Add(person1);
            array.Add(person2);
            array.Add(person3);

            for(int i= 0; i<array.Count;i++)
            {
                Console.WriteLine(((ClsPerson)array[i]).Name);  // + ",");
            }

            //for(int i=0;i<3;i++)
            //{
            //    ClsPerson Person1 = new ClsPerson("John");
            //    array[i] = (Person1);
            //}
        }
    }
    
    class ClsPerson
    {
        public string Name { get; set; }
        public ClsPerson(string name)
        {
            Name = name;
        }
    }
}
