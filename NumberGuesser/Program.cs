using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //app setup
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Leslie Alldridge";

            //change console text color and write out app info
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get name and save it to a string
            string inputName = Console.ReadLine();

            //Write out the greeting
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Init with correct number
            int correctNumber = 7;

            //Guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while(guess != correctNumber)
            {
                //get input
                string input = Console.ReadLine();
                //parse input to int
                guess = Int32.Parse(input);
                //match guess to correct number
                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number. Please try again.");
                    Console.ResetColor();
                }
            }
            //output success message 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Correct!!");
            Console.ResetColor();
        }
    }
}
