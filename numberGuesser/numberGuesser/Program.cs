using System;

namespace NumGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ashraf Besada";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's ply a game ...", inputName);

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                //Creat a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // Init guess var 
                int guess = 0;

                //Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {

                    //Get user input
                    string inputNumber = Console.ReadLine();

                    //Make sure only numbers used in input
                    if (!int.TryParse(inputName, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sorry, this is not a number. Please use an acutual number.");
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, wrong number. Please try again.");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Impressive! you are correct.");
                        Console.ResetColor();
                    }

                }

            }


        }

    }
}