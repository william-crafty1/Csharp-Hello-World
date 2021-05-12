using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Title
            Console.Title = "Hello World, let's tell a story";

            // Initialize Variables
            string firstName;
            string lastName;

            // User is prompted for First and last name.
            Console.WriteLine("Hello World. My first C# program!");
            Console.WriteLine("Please type in your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Okay! Now, please type in your last name:");
            lastName = Console.ReadLine();

            // Console will then respond with the first and last names in a complete sentence.
            Console.WriteLine("Your full name is " + firstName + " " + lastName + ". It's nice to meet you!");

            // The user will now use variables to tell a story.
            Console.WriteLine("Time to tell a story! Fill in the blanks to tell your own story.");

            Console.WriteLine("Once upon a time, there was a person named...");
            string character = Console.ReadLine();
            Console.WriteLine(character + " decided today was the day for an adventure.\n One day on their adventure, they stumbled upon...");
            string item = Console.ReadLine();
            Console.WriteLine("With " + item + " in hand, they set out to defeat...");
            string enemy = Console.ReadLine();
            Console.WriteLine(character + " fought bravely with " + item + ". In the end they defeated " + enemy + ".\nVictory seemed assured but suddenly a monster attacked! Their name was...");
            string monster = Console.ReadLine();
            Console.WriteLine(monster + " was bent on defeating our hero,\n but they both decided it was too much effort and agreed to just eat pizza and play video games.\n In the end, they learned...");
            string moral = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(moral + ". That's the end! Goodbye(press any key to end)");
            Console.ReadKey();


        }
    }
}
