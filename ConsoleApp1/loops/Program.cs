using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoopTest();
            // WhileTest();
            //Hw2();
            //arrayPractice();
            // Lab6();
            //HomePractice1();
            HomePractice2();

        }

        static void HomePractice2()
        {
            //variables
            int number = 5;
            do
                //do triggers the program to run over and over again till the requirements can not be fullfilled anymore
            {
                Console.WriteLine(number);
                number = number * 2;

            } while (number < 100);

        }

    static void HomePractice1()
            //basic loop
        {
            int x = 0;
            //continues till it lessthan or equal to 20
            while (x <= 20)
            {
                Console.WriteLine(x);
                x = x + 1;
            }
            Console.ReadLine();

        }

        //bubblesorting example
        public static void bubbleSort(string[] Names, string[] Phone)
        {
            string tempStr = "";
            string tempPhone = "";

            for (int i = 0; i < Names.Length; i++)
            {
                for (int j = 0; j < Names.Length - 1; j++)
                {
                    if (Names[j].CompareTo(Names[j + 1]) == -1)
                    {
                        tempStr = Names[j + 1];
                        Names[j + 1] = Names[j];
                        Names[j] = tempStr;

                        tempPhone = Phone[j + 1];
                        Phone[j + 1] = Phone[j];
                        Phone[j] = tempPhone;
                        break;
                    }
                }
            }
        }
        static void Lab6()
                    {
                        string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
                        string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
                        string strSearch;
                        // prompt user
                        Console.WriteLine("Type a name to search for in the phone book:");
                        strSearch = Console.ReadLine();
                        for (int n = 0; n < Names.Length; n++)
                        {
                            if (Names[n].IndexOf(strSearch) > -1)
                            { Console.WriteLine(Names[n] + "->" + Phone[n]); }
                        }
                        Console.ReadLine();
                    }

        static void arrayPractice()
        {
            {
                //variables
                int fSeq;

                Console.WriteLine("Enter the Range for the terms of fibonacci sequence");
                fSeq = Convert.ToInt32(Console.ReadLine());
                int[] arrFabSeq = new int[fSeq + 1];
                for (int f = 0; f <= fSeq; f++)


                    if (f < 2)
                    {
                        arrFabSeq[f] = f;
                        Console.WriteLine(f);
                    }

                    else
                    {
                        arrFabSeq[f] = arrFabSeq[f - 1] + arrFabSeq[f - 2];
                        Console.WriteLine(arrFabSeq[f]);
                    }
            }
        }
        static void Hw2()
        {
            //variables
            int fSeq = 0, lastlastnumber = 0, lastnumber = 1, tempnumber = 0;

            Console.WriteLine("Enter the Range for the terms of fibonacci sequence");
            fSeq = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < fSeq; i++)
            
            if (i < 2)
             { 
          Console.WriteLine(i);
             }
            else
          {
          Console.WriteLine(lastlastnumber + lastnumber);
                    tempnumber = lastlastnumber;
                    lastlastnumber = lastnumber;
                    lastnumber = lastnumber + tempnumber;
                }
            
        }
    
        static void ForLoopTest()
        {
            Console.WriteLine("Start at ");
            int init = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End at ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Increment ");
            int inc = Convert.ToInt32(Console.ReadLine());
            for (int i = init; i < end; i+=inc)

            { Console.WriteLine("at" +i);
            }
            Console.ReadLine();
        }
            
            static void WhileTest()
        {
            //declartions
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.WriteLine("Enter an integer");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer or Q to quit");
            strEntry = Console.ReadLine();

            //loop
            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);
                Console.WriteLine("Enter another integer or Q to Quit");
                strEntry = Console.ReadLine();
                //check to see if input should replace largest or smallest
                if(nCurrent > nLargest)
                { nLargest = nCurrent;}
                else if (nCurrent < nSmallest)
                { nSmallest = nCurrent;}
                Console.WriteLine("Enter annother integer or Q to Quit");
                strEntry = Console.ReadLine();
            }
            Console.WriteLine("The largest value you entered was" + nLargest + ".");
            Console.WriteLine("The smallest value you entered was" + nSmallest +".");
            Console.ReadLine();


        }
    }
}
