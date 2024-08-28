using System;
using System.Collections.Generic;



namespace MidTerm_
{

    public class AverageSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int> numbers)
        {

            if (numbers.Count == 0) 
            {
                Console.WriteLine("No numbers to summarize.");
                return;
            
            }

            double average = 0;
            foreach (var num in numbers)
            {
                average += num;
            }

            average /= numbers.Count;
            Console.WriteLine($"Average: {average}");



        }



    }






}