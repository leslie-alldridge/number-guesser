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
            string input = Console.ReadLine();

            //Write out the greeting
            Console.WriteLine("Hello {0}, let's play a game...", input);
        }
    }
}
