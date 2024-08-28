using System;
using System.Collections.Generic;


namespace MidTerm_
{
    class Program
    {

        static void Main(string[] args)
        {

            DataAnalyser analyser = new DataAnalyser();
            analyser.AddNumber(10);
            analyser.AddNumber(20);
            analyser.AddNumber(30);

            Console.WriteLine("Using Average Summary:");
            analyser.Summarise();

            analyser.Strategy = new MinMaxSummary();
            Console.WriteLine("Using Min-Max Summary:");
            analyser.Summarise();





        }





    }








}