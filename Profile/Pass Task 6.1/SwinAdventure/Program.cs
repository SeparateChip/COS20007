using System;

namespace SwinAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

           string name, desc;
           string help = $"-look\n\nGetting list of item:\n-look at me\n-look at bag\n\nGetting item description:\nlook at {item}\nlook at {item} in me\nlook at {item} in bag\n\n";

           Message greetings = new Message($"Welcome to SwinAdventure\n\nHere are some helpful commands:\n-look\n\nGetting list of items:\n-look at me\n-look at bag\n\nGetting item description:\nlook at {item}\nlook at {item} in me\nlook at {item} in bag")
           greetings.Print();
           Console.WriteLine("Press anything to continue...");
           Console.ReadLine();



            Console.Write("Setting up player: \nPlayer Name: ");
            name = Console.ReadLine();
            Console.Write("Player Description: ");
            desc = Console.ReadLine();
            Player player = new Player(name, desc);


            Item arrows = new Item(new string[] { "arrows" }, "Steel tipped", "Steel Arrows Dipped in Poison");
            Item sword = new Item(new string[] { "sword" }, "Silver Sword", "Perfect weapon for monsters");


            Bag bag = new Bag(new string[] { "bag" }, $"{player.Name}'s bag", $"This is {player.Name}'s bag");
            player.Inventory.Put(arrows, sword, bag);
            bag.Inventory.Put(diamond);


            string input;
            Command lookCommand = new lookCommand;


            while (true)
            {
                Console.WriteLine("Command: ");
                input = Console.ReadLine().ToLower();

                if(input == "quit")
                {
                    break;

                }

                else if(input == "help")
                {
                    Console.Write(help);

                }
                else
                {
                    LookCommandExe(lookCommand, input, player);

                }




            }

            static void LookCommandExe(Command lookCommand, string input, Player player)
            {
                Console.WriteLine(lookCommand.Execute(player, input.Split()));
            }



        }



    }






}
