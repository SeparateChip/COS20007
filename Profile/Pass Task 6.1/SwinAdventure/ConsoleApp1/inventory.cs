using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            return _items.Exists(item => item.AreYou(id));
        }

        public void Put(Item item)
        {
            _items.Add(item);
        }

        public Item Take(string id)
        {
            Item takenItem = Fetch(id);
            if (takenItem != null)
            {
                _items.Remove(takenItem);
            }

            return takenItem;
        }

        public Item Fetch(string id)
        {
            return _items.Find(item => item.AreYou(id));
        }

        public string ItemList
        {
            get
            {
                string itemList = "";

                foreach (Item item in _items)
                {
                    itemList += item.ShortDescription + "\n";
                }

                return itemList;
            }
        }
    }
}
