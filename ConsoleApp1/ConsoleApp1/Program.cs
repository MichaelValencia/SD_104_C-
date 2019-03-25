using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Lab1();
            // Lab2();
            // Homework1();
            //Lab3();
            Week1Hw();
            
        }
     

        static void Week1Hw()
        { //variables
            int x, y, number;

            Console.WriteLine("give me a number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me another number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (x + y));
            Console.WriteLine("Diff: " + (x - y));
            Console.WriteLine("Prod: " + x * y);
            Console.WriteLine("Divide: " + ((double)x / (double)y));
            Console.ReadLine();

            Console.WriteLine("enter an number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("number is less than 100",number);
            }
            else
            {
                if (number > 100)
                    Console.WriteLine("number is greater than 100");

            }

            while(true)
            {
                Console.WriteLine("which class would you like be" );
                Console.WriteLine("paladin, mage, shaman, monk, warlock, druid, Quit");
               string choice = Console.ReadLine();

                switch(choice.ToLower())
                {
                    case "paladin":
                        Console.WriteLine("you have chosen paladin class");
                        for (int i = 0; i < 8; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "mage":
                        Console.WriteLine("you have chosen mage class");
                        break;
                    case "shaman":
                        Console.WriteLine("you have chosen shaman class");
                        break;
                    case "monk":
                        Console.WriteLine("you have chosen monk class");
                        break;
                    case "warlock":
                        Console.WriteLine("you have chosen warlock class");
                        break;
                    case "druid":
                        Console.WriteLine("you have chosen the druid class");
                        break;
                    case "quit":
                        return;
                }
            }
           
           


        }
        static void Lab3()
        {
            /*
                    Project: lab3 calculate a user's Body Mass Index
                    this app should display one of the following messages from the department of health and human services:
                    BMI < 18.5 -underweight
                    BMI between 18.5 and 24.9 - normal weight
                    BMI between 25 and 29.9 - overweight
                    BMI > = 30 - obese
                    */

            // declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.WriteLine("Enter your Height in inches:");
            //validate
            while (!double.TryParse(Console.ReadLine(), out dblHeight) || dblHeight < 0)
            {
                Console.WriteLine("not valid. Must be a positive rational nuber.");
            }
            Console.WriteLine("Enter your Weight in pounds");


            //validate
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }


            //calculations
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);
            //issue result and message
            Console.WriteLine("your BMI is" + dblBMI);
            if (dblBMI < 18.5)
            { Console.WriteLine("BMI < 18.5 - underweight"); }
            else if (dblBMI <= 24.9)
            { Console.WriteLine("BMI between 18.5 and 24.9 - Normal"); }
            else if (dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9); - overweight");
            }
            else
            { Console.WriteLine("BMI >= 30 -obese"); }
            Console.ReadLine();
        }
        static void Homework1()
        {
            int nx, ny;
            Console.WriteLine("give me a number");
            nx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me a number");
            ny = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (nx + ny));
            Console.WriteLine("Diff: " + (nx - ny));
            Console.WriteLine("Prod: " + nx * ny);
            Console.WriteLine("Divide: " + ((double)nx / (double)ny));
            Console.ReadLine();
        }
        static void Lab2()
        {/*
           Project: Lab 2 calculate batting average
              Date: 3-16-2017
            Author: J. Monroe
            Notes : this program reads in a baseball player's name, number of hits and number of at bats.
            the player's batting average is calculated and display
            */
            //variable declaration
            string strPlayerName;
            double dblHits, nAtBats;
            double dblBattingAverage;

            // prompt for name and recieved
            Console.WriteLine("Enter the player's # of hits");
            dblHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of bats");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            strPlayerName = Console.ReadLine();

            //  calculation
            dblBattingAverage = dblHits / nAtBats;
            Console.WriteLine(strPlayerName + "player's batting average is" + dblBattingAverage);
            Console.ReadLine();
        }
        static void Lab1()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
