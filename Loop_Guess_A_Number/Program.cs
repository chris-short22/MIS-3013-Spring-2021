using System;

namespace Loop_Guess_A_Number
    //Christopher Short
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a whole number for the lower limit for the random number.");
            string lowerLimitString = Console.ReadLine();
            int lowerLimit = Convert.ToInt32(lowerLimitString);

            Console.WriteLine("Please provide a whole number for the upper limit for the random number.");
            string upperLimitString = Console.ReadLine();
            int upperLimit = Convert.ToInt32(upperLimitString);

            Random rand = new Random();
            int randNum = rand.Next(lowerLimit,upperLimit);

            Console.WriteLine($"This is the random number. {randNum}"); //just for testing purpose

            Console.WriteLine("Please enter your guess for the random number");
            string userGuessAsString = Console.ReadLine();
            int userGuess = Convert.ToInt32(userGuessAsString);



            while (userGuess != randNum)
            {
                Console.WriteLine("Sorry...that was not correct. Please try again");
                Console.WriteLine("Please enter another guess for the random number");
                userGuessAsString = Console.ReadLine();
                userGuess = Convert.ToInt32(userGuessAsString);
            }

           
            if (userGuess == randNum)
            {
                Console.WriteLine($"Wow! Your guess was correct! The number was {randNum}");
            }

        }
    }
}
