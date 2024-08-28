using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;



namespace SwinAdventure
{
    public class PlayerTest
    {
        Player _player;
        Item _arrows;
        Item _sword;


        [SetUp]
        public void Setup()
        {
            _sword = new Item(new string[] { "sword" }, "Silver Sword", "Perfect weapon for monsters");
            _arrows = new Item(new string[] { "arrows" }, "Steel tipped", "Steel Arrows Dipped in Poison");
            _player = new Player("Witcher", "Not Human anymore");
            _player.Inventory.Put(_sword);
            _player.Inventory.Put(_arrows);

        }


        [Test]
        public void TestPlayerIsIdentifiable()
        {

            Assert.IsTrue(_player.AreYou("me"));
            Assert.IsTrue(_player.AreYou("inventory"));
        }


        [Test]
        public void TestPlayerLocatesItem()
        {


            Assert.AreEqual(_sword, _player.Locate("sword"));

        }

        [Test]
        public void TestPlayerLocatesItself()
        {

            Assert.AreEqual(_player, _player.Locate("me"));
            Assert.AreEqual(_player, _player.Locate("inventory"));

        }

        [Test]
        public void TestPlayerLocatesNothing()
        {

            Assert.Null(_player.Locate("NonexistentID"));

        }

        [Test]
        public void TestPlayerFullDescription()
        {
            string expectedDescription = $"You are {_player.Name}, Scared and alone\nYou have with you:\n{_player.Inventory.ItemList}";
           Assert.AreEqual(expectedDescription, _player.FullDescription);
            



        }




    }





}