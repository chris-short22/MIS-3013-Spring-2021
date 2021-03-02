using System;

//correcting the capitalization of names when the characters are a mix of upper and lower case

namespace StringManupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string artist = "tAylOr SwIFt";
            //string newValue = artist.ToLower();
            artist = artist.ToLower();

            //                              Gives "T"     +      gives "aylor "     +     gives "S"     +     gives "wift"
            string artistWithProperName = artist.ToUpper()[0]+artist.Substring(1, 6) + artist.ToUpper()[7]+artist.Substring(8);
            



           // for (int i = 0; i < artistWithProperName.Length; i++)
            //{
              //  Console.WriteLine(artistWithProperName[i]);
           // }


            Console.WriteLine(artistWithProperName); //Console.WriteLine(newValue); either method works

        }
    }
}
