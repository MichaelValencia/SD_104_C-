using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            InterviewQuestions();
     
        }
        static void InterviewQuestions()

        {
            int Maxmultiplaction = 0;
            do
            {
                Console.WriteLine("enter a number between 2 and 20");
                //try is process that helps prevent the user from going out side the parameters of what you want them to do.
                try
                {
                    int MaxmultiplactionTable = Convert.ToInt32(Console.ReadLine());
                }
                //catch is the step that specify handlers for different exceptions
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (Maxmultiplaction < 2 || Maxmultiplaction > 20);
            for (int i = 0; i <= Maxmultiplaction; i++)
            {

                for (int j = 0; j <= Maxmultiplaction; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine();
            }

        }
     
    }
}

