using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_a_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a file name");
            
            ReadFile(Console.ReadLine());
        }

        private static void ReadFile(string fileName)
        {
            // Read the file and display it line by line. 
            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\" + fileName);

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
             
                Console.WriteLine(line);
            }
            file.Close();
        }
        private static void WriteFile(string fileName)
        {
            // Read the file and display it line by line. 
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\" + fileName);

            while (true)
            {
                string line = Console.ReadLine();
                if (line.Length == 0)
                    break;
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
