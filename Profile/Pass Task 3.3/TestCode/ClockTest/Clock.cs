using System;

namespace ClockTest
{
    public class Clock
    {
        private readonly Counter _seconds = new Counter("seconds");
        private readonly Counter _minutes = new Counter("minutes");
        private readonly Counter _hours = new Counter("hours");

        public void Tick()
        {
            _seconds.Increment();
            if (_seconds.Tick > 59)
            {
                _minutes.Increment();
                _seconds.Reset();
                if (_minutes.Tick > 59)
                {
                    _hours.Increment();
                    _minutes.Reset();
                    if (_hours.Tick > 23)
                    {
                        Reset();
                    }
                }
            }
        }

        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        public string Time()
        {
            return $"{_hours.Tick:D2}:{_minutes.Tick:D2}:{_seconds.Tick:D2}";
        }
    }
}
