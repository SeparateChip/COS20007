using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Input;
using System.Xml.Linq;
using NUnit.Framework;



namespace SwinAdventure
{

    public class LookCommandTest
    {
        Command Look;
        Player _player;
        Item _gem;
        string _gemDescription = "Flawless Gem";

        [SetUp]
        public void SetUp()
        {
            Look = new LookCommand();
            _player = new Player("Witcher", "Not Human anymore");
            _gem = new Item(new string[] { "gem" }, "Gem", _gemDescription);
            _player.Inventory.Put(_gem);
        }

        [Test]
        public void TestLookAtMe()
        {
            Assert.AreEqual(_player.FullDescription, Look.Execute(_player, new string[] { "look", "at", "inventory" }));
        }

        [Test]
        public void TestLookAtGem()
        {
            Assert.AreEqual(_gemDescription, Look.Execute(_player, new string[] { "look", "at", "gem" }));


        }

        [Test]
        public void TestLookAtUnknown()
        {

            _player.Inventory.Take("gem");
            Assert.AreEqual("I can't find the gem", Look.Execute(_player, new string[] { "look", "at", "gem" }));


        }


        [Test]
        public void TestLookAtGemInMe()
        {

            Assert.AreEqual(_gemDescription, Look.Execute(_player, new string[] { "look", "at", "gem", "in", "inventory" }));


        }



        [Test]
        public void TestLookAtGemInBag()
        {
            Bag bag = new Bag(new string[] { "bag" }, "bag", "a bag");
            bag.Inventory.Put(_gem);
            _player.Inventory.Put(bag);
            Assert.AreEqual(_gemDescription, Look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));
        }


        [Test]
        public void TestLookAtGemInNoBag()
        {

            Assert.AreEqual("I can't find the bag", Look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));


        }


        [Test]
        public void TestLookAtNoGemInBag()
        {

            Bag bag = new Bag(new string[] { "bag" }, "bag", "a bag");
            _player.Inventory.Put(bag);
            Assert.AreEqual("I can't find the gem", Look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));


        }

        [Test]
        public void TestValidLook()
        {

            string invalidSizeError = "I don't know how to look like that";
            string lookError = "Error in look input";
            Assert.AreEqual(invalidSizeError, Look.Execute(_player, new string[] { }));
            Assert.AreEqual(invalidSizeError, Look.Execute(_player, new string[] { "a", "b", "c", "d" }));
            Assert.AreEqual(invalidSizeError, Look.Execute(_player, new string[] { "a" }));
            Assert.AreEqual(lookError, Look.Execute(_player, new string[] { "a", "b", "c" }));


        }






    }



}