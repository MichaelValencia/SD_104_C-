using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {

            int[] scores = { 100, 55, 88, 33, 66, 99 };
            string[] names = { "josephine", "arianne", "manuel", "sam", "jose", "mike" };
            int[] numbers = new int[20];
            Console.WriteLine(names[names.Length - 1] + "is in the house!!");

            for (int x = 0; x < names.Length; x++)
            {
                Console.WriteLine(x + " " + names[x]);
            }

            int i, sum = 0, average = 0;
            for (int i = 0, i < scores.length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum / scores.length);
        }
    }
}

