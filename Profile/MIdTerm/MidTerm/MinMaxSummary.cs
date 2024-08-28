using System;
using System.Collections.Generic;
using System.Linq;


namespace MidTerm
{

    public class MinMaxSummary : SummaryStrategy
    {

        public override void PrintSummary(List<int> numbers)
        {


            Console.WriteLine("Min: " + numbers.Min().ToString() + ", Max: " + numbers.Max().ToString());



        }





    }




}
