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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            //change text color
        }
    }
}
