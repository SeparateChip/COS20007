using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventure
{

    public class InventoryTest
    {
        Inventory _inventory;
        Item _arrows;
        Item _sword;

        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
            _sword = new Item(new string[] { "sword" }, "Silver Sword", "Perfect weapon for monsters");
            _arrows = new Item(new string[] { "arrows" }, "Steel tipped", "Steel Arrows Dipped in Poison");
            _inventory.Put(_sword);
            _inventory.Put(_arrows);
        }

        [Test]
        public void TestFindItem()
        {
            Assert.IsTrue(_inventory.FindItem("sword"));
            Assert.IsTrue(_inventory.FindItem("arrows"));
        }

        [Test]
        public void TestNoItemFound()
        {
            Assert.IsFalse(_inventory.FindItem("bow"));
        }

        [Test]
        public void TestFetchItem()
        {
            Assert.AreEqual(_sword, _inventory.FetchItem("sword"));
            Assert.AreEqual(_sword, _inventory.FetchItem("Arrows"));
        }

        [Test]
        public void TestTakeItem()
        {
            Assert.IsTrue(_inventory.FindItem("sword"));
            Assert.AreEqual(_sword, _inventory.TakeItem("sword"));
            Assert.IsFalse(_inventory.FindItem("sword"));
        }

        [Test]
        public void TestItemList()
        {
            string itemListString = "\t" + _sword.ShortDescription + "\n\t" + _arrows.ShortDescription + "\n";
            Assert.AreEqual(itemListString, _inventory.ItemList);
        }
    }
}
