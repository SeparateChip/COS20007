using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;





namespace SwinAdventure
{

    public class Bag : Item
    {
        public Inventory Inventory
        {
            get;
        }

        public Bag(string[] ids, string name, string description) : base(ids, name, description)
        {
            Inventory = new Inventory();
        }

        public void AddItemToBag(Item item)
        {
            Inventory.Put(item);

        }

        public List<Item> GetItemsInBag()
        {
            return Inventory.ItemList;
        }


    }





}
