using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String name = Console.ReadLine();
            Console.WriteLine(name);
            int age;
            Console.Write("What is your age?");
            string strAge = Console.ReadLine();
            age = Convert.ToInt32(strAge);
            Console.WriteLine(name + " is " + age + " years old");
            Console.ReadLine();
        }   
    }
}
