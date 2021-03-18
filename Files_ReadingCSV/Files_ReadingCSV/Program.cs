using System;
using System.Collections.Generic;
using System.IO;

namespace Files_ReadingCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");

            Console.WriteLine(lines);
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();

            for (int i = 3; i < lines.Length; i++) //starting at line 3 of the data "i=3"
            {
                //"Alabama,16%,84%"
                string line = lines[i];

                //"Alabama","16%","84%"
                string[] pieces = line.Split(",");
                string state = pieces[0]; //outputs just the state names
                states.Add(state);

                string soccerScoresAsString = pieces[1].Remove(pieces[1].Length-1); //this will be on the final!!!
                double soccerScore = Convert.ToDouble(soccerScoresAsString)/100;
                soccerScores.Add(soccerScore);

                footballScores.Add(Convert.ToDouble(pieces[2].Remove(pieces[1].Length - 1)) / 100);

                //Console.WriteLine(state);

            }
            for (int i = 0; i < footballScores.Count; i++)
            {
                string state = states[i];
                double soccer = soccerScores[i];
                double fooball = footballScores[i];

                if (soccer > fooball)
                {
                    Console.WriteLine(state);
                }
            }
            //Console.WriteLine();
        
        }
    }
}
