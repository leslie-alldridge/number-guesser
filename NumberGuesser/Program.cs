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

            while (true)
            {

                //Init with correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get input
                    string input = Console.ReadLine();
                    //check input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ResetColor();
                        continue;
                    }

                    //parse input to int
                    guess = Int32.Parse(input);
                    //match guess to correct number
                    if (guess != correctNumber)
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

                //Ask to play again
                Console.WriteLine("Do you want to play another round? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                } else
                {
                    return;
                }

            }
        }
    }
}
