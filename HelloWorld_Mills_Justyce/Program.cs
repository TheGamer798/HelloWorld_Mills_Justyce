using System;

namespace HelloWorld_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");//asking for first name
            string fisrtName = Console.ReadLine();//remembers first name
            Console.WriteLine("What is your last name?");//asks for last name
            string lastName = Console.ReadLine();//remembers last name
            Console.WriteLine($"So your name is {fisrtName} {lastName}, interesting.");//tells you your full name
        }
    }
}
