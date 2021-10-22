using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo Function

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Init Correct Number
                //int correctNumber = 7;

                // Create a new Random Object
                Random random = new Random();

                // Init Correct Number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a valid number.");

                        // Keep Going
                        continue;
                    }
                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You got it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") 
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and Display app info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Joshua Cunningham";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();
        }

        // Ask User name and greet
        static void GreetUser()
        {
            // Ask User's name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }

        // Print Color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it's not a number
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }
    }
}
