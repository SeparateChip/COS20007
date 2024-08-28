using System;

namespace SwinAdventure
{
    public class Message
    {
        private string _content;

        public Message(string content)
        {
            _content = content;
        }

        public void Print()
        {
            Console.WriteLine(_content);
        }
    }
}
