using System;
using System.Collections.Generic;



namespace MidTerm_
{

    public class MinMaxSummary : SummaryStrategy
    {
        public override void PrintSummary(List<int>numbers)
        {

            if (numbers.Count == 0) 
            {
                Console.WriteLine("No numbers to summarize.");
                return;

            }
            int min = numbers[0];
            int max = numbers[0];


            foreach(var num in numbers) 
            { 
                if (num < min) min = num;
                if (num > max) max = num;
            
            }

            Console.WriteLine($"Min: {min}, Max: {max}");


        }


    }







}