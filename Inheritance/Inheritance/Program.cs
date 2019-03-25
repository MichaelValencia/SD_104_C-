using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance, amount;
            string accountName;
            string change = MakingChange(4.44M);
            Console.WriteLine(change);
            int menuOption = 0;
            Checking checking = null;
            Savings savings = null;

            while (menuOption != 1)
            {
                menuOption = GetNumber("1 - Exit\n2 - Create Checking\n3 - Create Savings\n4 Check Balance\n5 savings balance\n6 deposit to checking\n7 deposit to savings");
                switch (menuOption)
                {
                    //  exit the ATM
                    case 1:
                        break;

                    case 2:
                        accountName = GetInput(" Account Name ");
                        balance = GetNumber("Initial Amt: ");
                        checking = new Checking(accountName, balance, 0.02f);
                        break;

                    case 3:
                        accountName = GetInput(" Account Name ");
                        balance = GetNumber("Initial Amt: ");
                        savings = new Savings(accountName, balance, 0.03f);
                        break;
                    case 4:
                        Console.WriteLine("my checking balance is " + checking.Balance);
                        break;
                    case 5:
                        Console.WriteLine(" my savings balance is" + savings.Balance);
                        break;
                    case 6:
                        amount = GetNumber(" Deposit amount ");
                        checking.Deposit( amount );
                        break;
                    case 7:
                        amount = GetNumber(" Deposit amount ");
                        savings.Deposit( amount );
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
        public static string MakingChange(decimal change)
        {
            int dollars, quarters, dimes, nickels, pennies;
            Random rnd = new Random();

            dollars = (int)(change / 1.0M);
            change %= 1M;
            quarters = (int)(change / .25M);
            dimes = (int)(change / .10M);
            nickels = (int)(change / .05M);
            pennies = (int)(change / .01M);

            return dollars + " dollars " + quarters + " quarters " + dimes + " dimes " + nickels + " nickels " + pennies + " pennies ";
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }
        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }
        public static string MakeChange(decimal change)
        {
            return "change";
        }
    }
}
