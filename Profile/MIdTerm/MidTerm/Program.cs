
using System;
using System.Collections.Generic;

namespace MidTerm
{

    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DataAnalyser analyser = new DataAnalyser(numbers, new MinMaxSummary());

            analyser.Summarise();

            analyser.AddNumber(11);
            analyser.AddNumber(12);
            analyser.AddNumber(13);

            analyser.Strategy = new AverageSummary();
            analyser.Summarise();


        }



    }




}