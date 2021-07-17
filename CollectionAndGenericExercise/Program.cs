using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionAndGenericExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrL = new ArrayList();
            bool acceptFlag = false;
            while(!acceptFlag)
            {
                Console.WriteLine("Enter some integer");
                int i = int.Parse(Console.ReadLine());

                arrL.Add(i);
                Console.WriteLine("Do you want to continue? Y/N");
                char accept = char.Parse(Console.ReadLine().ToString().ToUpper());

                if (accept == 'Y')
                    acceptFlag = true;
                else
                    acceptFlag = false;
            }
            double avg = 0;
            float sum = 0;
            foreach(var i in arrL)
            {
                sum += (int)i;
            }
            avg = sum / arrL.Count;
            //if(arrL.Count % 2 == 0)
            //{
                int mid = (arrL.Count / 2) + 1;
                arrL.Insert(mid-1, avg);
            //}
            //else
            //{
            //    int mid = (arrL)
            //}
            Console.WriteLine("Total Numbers inserted are: {0}",arrL.Count);
            Console.WriteLine("Array after adding avg value is: ");
            for(int j=0;j<arrL.Count;j++)
            {
                Console.Write(arrL[j] + ",");
            }

            arrL.Remove(arrL[1]);  // takes value to be remove as parameter
            arrL.RemoveAt(mid - 1); // takes index as parameter
            Console.WriteLine("Array after removing element value is: ");
            for (int j = 0; j < arrL.Count; j++)
            {
                Console.Write(arrL[j] + ",");
            }


        }
    }
}
