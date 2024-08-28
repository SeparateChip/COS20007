 using NUnit.Framework;

namespace ClockTest
{

    public class TestCounter
    {
        Counter _counterTest;

        [SetUp]
        public void Setup()
        {
            _counterTest = new Counter("TEST");
        }

        [Test]
        public void TestName()
        {
            Assert.AreEqual("TEST", _counterTest.Name);
        }

        [TestCase(60, 60)]
        [TestCase(120, 120)]
        public void TestIncrement(int increment, int TimeResults)
        {
            for (int i = 0; i < increment; i++)
            {
                _counterTest.Increment();
            }
            Assert.AreEqual(TimeResults, _counterTest.Tick);

        }

        [Test]
        public void TestReset()
        {
            _counterTest.Increment();
            _counterTest.Reset();
            Assert.AreEqual(0, _counterTest.Tick);
        }

    }


}