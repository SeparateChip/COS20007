using NUnit.Framework;


namespace ClockTest
{
    public class TestsClock
    {
        Clock _clock;

        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestClockTime()
        {
            Assert.AreEqual("00:00:00", _clock.Time());
        }

        [TestCase(0, "00:00:00")]
        [TestCase(3600, "01:00:00")]
        [TestCase(7200, "02:00:00")]
        [TestCase(10800, "03:00:00")]
        [TestCase(86400, "00:00:00")]

        public void TestClockRunning(int tick, string TimeResult)
        {
            for (int i = 0;i < tick;i++)
            {
                _clock.Tick();
            }

            Assert.AreEqual(TimeResult, _clock.Time(), "error in ticks");
        }



        [Test]
        public void TestClockReset()
        {
            for (int i = 0; i < 36000; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
        }


    }
}