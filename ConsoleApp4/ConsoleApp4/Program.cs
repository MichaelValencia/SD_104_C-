using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int outer = 0; outer < 2; outer++) 
            {
                for (int inner =0; inner <3; inner++ )
                { Console.WriteLine("outer:{0}/tInner:{1}",outer,inner); }
            }
        }
    }
}