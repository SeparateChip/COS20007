using System;
using System.Collections.Generic;



namespace MidTerm_
{

    public class DataAnalyser
    {
        private List<int> _numbers;
        private SummaryStrategy _strategy;


        public SummaryStrategy Strategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }

        public DataAnalyser()
        {
            _numbers = new List<int>();
            _strategy = new AverageSummary();
        }

        public DataAnalyser(List<int> numbers, SummaryStrategy strategy = null)
        {   
            _numbers = numbers;
            _strategy = strategy ?? new AverageSummary();
        }

        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }

        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);


        }
    }



}