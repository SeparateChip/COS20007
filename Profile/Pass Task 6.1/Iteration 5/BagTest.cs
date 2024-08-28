using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SwinAdventure
{
    public class BagTest
    {
        Bag _bag1, _bag2;
        Item _arrows, _sword;

        [SetUp]
        public void Setup()
        {
            _bag1 = new Bag(new string[] { "b1", "Small Bag" }, "Made out of Leather", "Small enough to carry a few items");
            _bag2 = new Bag(new string[] { "b2" }, "large bag", "an endless pit, you can put as many items and it still be lighter than a feather");
            _sword = new Item(new string[] { "sword" }, "Silver Sword", "Perfect weapon for monsters");
            _arrows = new Item(new string[] { "arrows" }, "Steel tipped", "Steel Arrows Dipped in Poison");
            _bag1.Inventory.Put(_arrows);
            _bag2.Inventory.Put(_sword);
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.AreEqual(_bag1, _bag1.Locate("b1"));
            Assert.AreEqual(_arrows, _bag1.Locate("arrows"));
        }

        [Test]
        public void TestBagLocatesItself()
        {
            Assert.AreEqual(_bag1, _bag1.Locate("Small Bag"));
            Assert.AreEqual(_bag1, _bag1.Locate("b1"));
        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.AreEqual(null, _bag1.Locate("Nothing"));
        }

        [Test]
        public void TestBagFullDescription()
        {
            Assert.AreEqual(_bag1.FullDescription, "Made out of Leather, Small enough to carry a few items, containing:\nSteel tipped (arrows)\n");
        }

        [Test]
        public void TestBagInBag()
        {
            _bag1.Inventory.Put(_bag2);
            Assert.AreEqual(_bag2, _bag1.Locate("b2"));
            Assert.AreEqual(_arrows, _bag1.Locate(_arrows.FirstID));
            Assert.IsNull(_bag1.Locate("sword"));
        }
    }
}
