using System;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" }) { }

        public override string Execute(Player player, string[] text)
        {
            FullInventory container;
            string itemId;
            string error = "Error in Look input";

            if (text[0].ToLower() != "look")
                return error;

            switch (text.Length)
            {
                case 2:
                    container = player;
                    itemId = text[1];
                    break;

                case 4:
                    if (text[2].ToLower() != "at")
                        return "What do you want to look at?";
                    container = FetchContainer(player, text[3]);
                    if (container == null)
                        return "Could not find " + text[3];
                    itemId = text[1];
                    break;

                default:
                    container = player;
                    itemId = "me";
                    break;
            }


            return LookAtIn(itemId, container);
        }


        private string LookAtIn(string itemId, FullInventory container)
        {

            return $"Looking at {itemId} in {container.Name}";
        }


        private FullInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as FullInventory;
        }
    }
}
