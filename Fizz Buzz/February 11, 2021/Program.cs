using System;

namespace February_11__2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate random number (0-100)
            //divisible by 3: fizz
            //divisible by 5: buzz
            //divisible by 3 and 5: fizz buzz
            //if not divisible by 3 or 5: just output the number

            Random rand = new Random();
            int randomNum = rand.Next(1, 101); //generate random number (1-100)
            int isDivisibleBy3Remainer = randomNum % 3;
            bool isDivisibleBy3 = isDivisibleBy3Remainer == 0;
            //if (isDivisibleBy3Remaider)


            if (randomNum % 3 == 0
                && randomNum % 5 == 0) 
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (randomNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNum % 3 == 0) //==true
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randomNum);
            }

        }
    }
}
