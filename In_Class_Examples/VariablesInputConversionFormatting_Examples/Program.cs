using System;

namespace VariablesInputConversionFormatting_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            double gpa;

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your gpa >>");
            string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; //bump gpa by 0.5 because of the COVID Semester

            string output = "Hello " + firstName + " " + lastName + "! " + "We boosted your gpa to " + gpa.ToString("N3");

            Console.WriteLine(output);

            //string output = "Hello {firstName} {LastName}! we boosted your gpa to {gpa.ToString("N3")";
            
        

        }
    }
}
