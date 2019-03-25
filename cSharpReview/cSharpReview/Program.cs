using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Console.WriteLine( "enter the day of the week");
            string weekDay = Console.ReadLine();
            int hoursToWeekend;
            switch (weekDay)

            {
                case "monday ": hoursToWeekend = 120; break;
                case "tuesday ": hoursToWeekend = 96; break;
                case "wednesday ": hoursToWeekend = 72; break;

                case "thursday": hoursToWeekend = 48; break;
                case "friday ": hoursToWeekend = 24; break;
                case "saturday":
                case "sunday": hoursToWeekend = 0; break;

                default:
                    hoursToWeekend = -1;
                    Console.WriteLine("not a valid day of the week");
                    break;
                    //after the switch
                    // if the number of hours is 0, print its the weekend
                    if (hoursToWeekend > 0)
                    {
                        Console.WriteLine("we have to wait " + hoursToWeekend + " before the weekend begins");
                    }
                    else if (hoursToWeekend ==0)
                    {
                        Console.WriteLine("it is the weekend");
                    }
                    else
                    {
                        Console.WriteLine(weekDay + "is not a valid day of the week");
                    }

            }
        }
        // this is the end of my program class. all my methods go above this line
        //this is the end of my name space
    }
    }
}
