using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           Shirts myShirt = new Shirts("black","s","Y");
            shoes myShoes = new shoes("white", "nike", "9");
            pants myPants = new pants("30 inches", "33 inches", "blue", "Levi's");
            Console.WriteLine(myPants.ToString());
            Console.WriteLine(myShirt.ToString());
            Console.WriteLine(myShoes.ToString());
            Console.ReadLine();

        }
    }
}
