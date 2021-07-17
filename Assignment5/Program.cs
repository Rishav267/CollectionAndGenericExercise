using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ClsPerson> Dicts = new Dictionary<string, ClsPerson>();
           

            ClsPerson clsPerson1 = new ClsPerson();
            clsPerson1.Name = "John";
            clsPerson1.Age = 16;
            clsPerson1.PlaceBirth = "Chennai";
            Dicts.Add("John", clsPerson1);

            ClsPerson clsPerson2 = new ClsPerson();
            clsPerson2.Name = "Smita";
            clsPerson2.Age = 22;
            clsPerson2.PlaceBirth = "Delhi";
            Dicts.Add("Smita", clsPerson2);

            ClsPerson clsPerson3 = new ClsPerson();
            clsPerson3.Name = "Vincent";
            clsPerson3.Age = 20;
            clsPerson3.PlaceBirth = "Banaglore";
            Dicts.Add("Vincent", clsPerson3);

            ClsPerson clsPerson4 = new ClsPerson();
            clsPerson4.Name = "Jyothi";
            clsPerson4.Age = 10;
            clsPerson4.PlaceBirth = "Banaglore";
            Dicts.Add("Jyothi", clsPerson4);

            foreach(var keyP in Dicts)
            {
                Console.WriteLine("{0} {1} {2} {3}", keyP.Key, keyP.Value.Age, keyP.Value.PlaceBirth, keyP.Value.CanVote());
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("printing after sorting the Dictionary");
            Console.WriteLine("\n");

            foreach (KeyValuePair<string,ClsPerson> keyP in Dicts.OrderBy(keyP => keyP.Key))
            {
                Console.WriteLine("{0} {1} {2} {3}", keyP.Key, keyP.Value.Age, keyP.Value.PlaceBirth, keyP.Value.CanVote());
            }
        }
    }
    class ClsPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string PlaceBirth { get; set; }

        public bool CanVote()
        {
            if (Age >= 18)
                return true;
            else
                return false;
        }

        public ClsPerson()
        {

        }
    }
}
