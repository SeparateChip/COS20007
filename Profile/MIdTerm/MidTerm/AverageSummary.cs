using System;
using System.Collections.Generic;
using System.Linq;





namespace MidTerm
{

    public class AverageSummary : SummaryStrategy
    {

        public override void PrintSummary(List<int> numbers)
        {

            Console.WriteLine("Average: " + numbers.Average().ToString());


        }


    }




}
