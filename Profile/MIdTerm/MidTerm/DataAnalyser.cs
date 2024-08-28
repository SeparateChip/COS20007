using System.Collections.Generic;
using System.Linq;
using System;


namespace MidTerm
{
    public class DataAnalyser
    {


        private List<int> _numbers;
        private SummaryStrategy _strategy;

        public SummaryStrategy Strategy 
        { 
            get { return _strategy; } 
            set {  _strategy = value; } 
        }

        public DataAnalyser()
        {
            _numbers = new List<int>();
            _strategy = new AverageSummary();
        }

        public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
        {
            _numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void AddNumber(int number)
        {
            _numbers.Add(number);

        }

        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }



    }




} 