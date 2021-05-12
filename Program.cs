using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            Console.WriteLine("Hello World. My first C# program!");
            Console.WriteLine("Please type in your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Okay! Now, please type in your last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName + ". It's nice to meet you!");

            Console.WriteLine("Now, we're going to do math. Enter a number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of your two numbers is: " + sum);


        }
    }
}
