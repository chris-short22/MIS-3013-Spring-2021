using System;

namespace Shipping_PP_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of miles...");
            string answer1 = Console.ReadLine();
            //double miles = Convert.ToDouble(answer1);
            double miles;
            bool isSuccessfull = double.TryParse(answer1, out miles);

            if (isSuccessfull == false)
            {
                Console.WriteLine("Invalid input. Bye bye");
                Environment.Exit(-1);
            }

            Console.WriteLine("Please enter the number of miles...");
            string answer = Console.ReadLine();
            //double miles = Convert.ToDouble(answer1);
            double weight;

            if (double.TryParse(answer, out weight) == false) 
            {
                Console.WriteLine("Invalid input. Bye bye");
                Environment.Exit(-2);
            }

            Console.WriteLine("Does your shipment contain hazardous material? yes or no?");
            answer = Console.ReadLine();

            double quote = .55 * miles + .73 * weight;

            double hazardousCost;
            if (answer.ToLower() == "yes")
            {
                 hazardousCost = .015 * weight;
            }
            else
            {
                hazardousCost = 0;
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;
            if (miles < 150 && weight < 500)
            {
                discount = 0.10 * netTotal;
            }
 

            double total = netTotal - discount;

            Console.WriteLine($"Quote: \t\t{quote.ToString("C")}");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hazardous Cost: \t{hazardousCost.ToString("C")}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Discount: \t{discount.ToString("C")}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total: \t{total.ToString("C")}");



        }
    }
}
