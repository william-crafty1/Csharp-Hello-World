using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Title
            Console.Title = "Hello World, let's do basic C#";

            // Initialize Variables
            string firstName;
            string lastName;

             // Initialize Variables for math portion
            double answer;
            double firstNumber;
            double secondNumber;
            double sum;
            double multiplication;
            double division;
            double average;
            int score = 0;
            double cash = 0;

            // Initialize variables for loop.
            Random rndNumber = new Random();
            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;



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
            Console.WriteLine(moral + ". That's the end! Now onto Math!");
            Console.ResetColor();


            // Math portion of the program is executed


            Console.WriteLine("We are going to do math problems and 'If Statements'. Press any key to continue.");
            Console.ReadKey();

            // Program will ask for two numbers which are bing converted from String to Int.
            // Line 29 adds the two converted numbers and 30 is logging the sum. 
            Console.WriteLine("Enter a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now enter a second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            sum = firstNumber + secondNumber;
            multiplication = firstNumber * secondNumber;
            division = firstNumber / secondNumber;
            average = sum / 2;

            Console.WriteLine("The sum of your two numbers is: " + sum);
            Console.WriteLine("The product of your two numbers is: " + multiplication);
            Console.WriteLine("The division of your two numbers is: " + division);
            Console.WriteLine("The average of your two numbers is: " + average);

            // If statements to determine if the answer given is correct
            // One point is given for each correct answer, one is subtracted for each wrong answer 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Time for a math quiz!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Question 1: What is 2 + 2?");
            answer = Convert.ToDouble(Console.ReadLine());

            if (answer == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score--;
            }

            Console.WriteLine("Question 2: What is 12 * 12?");
            answer = Convert.ToDouble(Console.ReadLine());

            if (answer == 144)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score--;
            }

            Console.WriteLine("Question 3: What is 62 + 75 - 100?");
            answer = Convert.ToDouble(Console.ReadLine());

            if (answer == 37)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score--;
            }

            Console.WriteLine("Question 4: What is (100 / 25) * (12 + 55) - 100?\nRemember order of operations!!!");
            answer = Convert.ToDouble(Console.ReadLine());

            if (answer == 168)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score--;
            }

            Console.WriteLine("Final Question: What is (500 * 5) + (32 - 8) * (300 - 150)?\nRemember order of operations!!!");
            answer = Convert.ToDouble(Console.ReadLine());

            if (answer == 6100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ForegroundColor = ConsoleColor.Gray;
                score--;
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your final score is " + score);

            /* If statement to check if a number is greater or less than the total amount, 
            the difference is returned if the number is greater than the total. */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let's go shop for a new game, how much money do you have?\nThe game is $60");

            cash = Convert.ToDouble(Console.ReadLine());

            if (cash < 60)
            {
                Console.WriteLine("Sorry, not enough cash!");
            }
            else if(cash == 60){
                Console.WriteLine("You have enough money, enjoy your game!");
            }
            else{
                cash = cash - 60;
                Console.WriteLine("Thank you, your change is $" + cash);
            }


            // Loop portion of program is executed
            Console.WriteLine("Time to do loops, press any key to continue.");
            Console.ReadKey();

            // Simple For Loop
            Console.WriteLine("Simple for loops");
            for(int i = 10; i > 0; i--){
                Console.WriteLine(i);
            }

            // Dice rolls using a While loop 
            Console.WriteLine("Testing a While loop, try to match 2 pairs of dice! Press any key to roll!");

            while(roll1 != roll2){
                Console.ReadKey();
                roll1 = rndNumber.Next(1,7);
                roll2 = rndNumber.Next(1,7);
                Console.WriteLine("Dice 1 rolled a  " + roll1);
                Console.WriteLine("Dice 2 rolled a  " + roll2);

                if(roll1 == 1 && roll2 == 1){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You got Snake eyes!");
                    Console.ResetColor();
                }

                attempts++;
            }

            Console.WriteLine("It has taken you " + attempts + " attempts to roll a 6.");


            // wait for input to end program.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Thanks for playing, goodbye!");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
