using System;

namespace Exam1_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            Console.WriteLine("Input a number");
            string userNumAsString = Console.ReadLine();

            int.TryParse(userNumAsString, out userNum);

            Console.WriteLine(userNum);

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                if (i == 0)
                {
                    Console.WriteLine("Blast off bitches");
                }
            }
            
            
        }
    }
}
