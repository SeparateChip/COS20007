using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message MyMessage;
            Message[] messages = new Message[4];
            messages[0] = new Message("ooooh my god!!");
            messages[1] = new Message("Drop a gear and Disapear");
            messages[2] = new Message("Why wont you call me back? :(");
            messages[3] = new Message("With a Pencil!");
                                

            MyMessage = new Message("Hello World - from Message Object");
            MyMessage.Print();

            while (true)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                name = name.ToLower();



                if (name == "dimi")
                {
                    messages[0].Print();
                }
                else if (name == "brian636")
                {
                    messages[1].Print();
                }
                else if (name == "monica")
                {
                    messages[2].Print();
                }
                else if (name == "wick")
                {
                    messages[3].Print();
                }
                else
                {
                    break;
                }
            }


        }
    }
}