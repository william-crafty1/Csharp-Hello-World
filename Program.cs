using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World. My first C# program!");
            string firstName;
            string lastName;
            Console.WriteLine("Please type in your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Okay! Now, please type in your last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName + ". It's nice to meet you!");
        }
    }
}
