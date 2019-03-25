using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //put in a loop to play the game
            //call a method to play the guessing game method
            //the method will take one parameter - a random number between 1 and 100
            // and return how many guesses the user made to get the right answer
            while (true)
            {
                int numberOfGuesses = GuessNumber(RandomNumber(random, 1, 100));
                string answer = GetInput("would you like to play again?");

                if (answer == "quit")
                    break;
            }
           

        }
        public static int GuessNumber(int randomNumber)
        {

            //new method here --- Guessnumber it will have one parameter the number to guess
            // and will return the count of tries the user had to make to guess the number
            int numberOfGuesses = 0;
            // you will ask the user for a number and then compare that number to the number passed in the method
            while (true)
            {
                int guess = GetNumber("what's your guess?'");
                numberOfGuesses++;
                if (guess < randomNumber)
                {
                    //too low -give an error message
                    Console.WriteLine("too low");
                }
                else if (guess > randomNumber)
                {//too high - give an error message
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("congrats you are correct!");
                    break;
                }
            }
            //just right - give a winner message
            //then return the number of tries the user made
            Console.WriteLine(randomNumber);


            Console.WriteLine("number Of Guesses");
            Console.WriteLine(numberOfGuesses);
            return numberOfGuesses;
        }
        private static int RandomNumber(Random random, int min, int max)

        {

            return random.Next(min, max);
        }
        private static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("that is not an integer");
                strNumber = GetInput(prompt);

            }
            return userNumber;
        }
        private static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string str = Console.ReadLine();
            return str;
        }
    }


}
