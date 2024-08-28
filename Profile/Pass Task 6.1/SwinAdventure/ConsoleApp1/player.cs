using System;

namespace SwinAdventure
{
    public class Player : GameObject, FullInventory
    {
        private Inventory _inventory;

        public Player(string name, string desc) :
            base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            return AreYou(id) ? this : _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                return $"You are {Name}, and you are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory => _inventory;
    }
}
