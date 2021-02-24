using System;

namespace Loop_Guess_A_Number
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
            int guessNum = rand.Next(lowerLimit,upperLimit);


        }
    }
}
