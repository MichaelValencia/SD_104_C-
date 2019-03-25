using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {//variable
            string name;

            Console.WriteLine("enter some text");
            name = Console.ReadLine();
           
            Console.WriteLine(name);
            //print the length of your name
            Console.WriteLine(name.Length);
            //find a certain letter of the name.
            int findA;
            findA = name.IndexOf('a');
            Console.WriteLine(findA);
            // to find letter after the first intial letter you and ++ before to continue looking for another same character
            findA = name.IndexOf('a', ++findA);
            Console.WriteLine(findA);
            //repeat to continue searching for the next character
            findA = name.IndexOf('a', ++findA);
            Console.WriteLine(findA);
            //if it ends with it will be considered true. if not its false
            bool endswith = name.EndsWith("cia");
            Console.WriteLine(endswith);
            //works from the end of the name looking for the character of
            int x = name.LastIndexOf("a");
            Console.WriteLine(x);

           
            if (name.Contains("i"))
            {
                Console.WriteLine("you found it");
            }
            else
            {
                if (name.Contains("l"))
                {
                    Console.WriteLine("you found what your looking for");
                }

                else
                {
                    if (name.Contains("z"))
                        Console.WriteLine("this character is was not found");
                }




                Console.WriteLine("found what your looking for");

                string sub = name.Substring(x);
                Console.WriteLine(sub);
                sub = name.Substring(x);
                Console.WriteLine(sub);
            }

        }
    }
}
