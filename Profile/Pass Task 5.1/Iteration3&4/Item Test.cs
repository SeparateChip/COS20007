using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventure
{
    [TestFixture]
    public class ItemTest
    {
        Item arrows = new Item(new string[] { "arrows" }, "Steel tipped", "Steel Arrows Dipped in Poison");
        Item sword = new Item(new string[] { "sword" }, "Silver Sword", "Perfect weapon for monsters");
        [SetUp]
        public void Setup()
        {
            string[] testStringArray = new string[] { "sword" };
            string name = "Silver Sword";
            string desc = "Perfect weapon for monsters";
            item = new Item(testStringArray, name, desc);
        }

        [Test]
        public void TestItemIsIdentifiable()
        {
            Assert.IsTrue(item.AreYou("sword"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual("Silver Sword", item.ShortDescription);
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual("Perfect weapon for monsters", item.FullDescription);
        }
    }
}
