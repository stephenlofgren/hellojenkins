using System;

namespace helloworld
{
    public class Program
    {
        IMessageWriter writer {get;set;}
        static void Main(string[] args)
        {
            WriteMessage(CreateMessage());
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string CreateMessage()
        {
            return "Hello World";
        }
    }

    public interface IMessageWriter
    {
        void WriteMessage(string message);
    }

    public class ConsoleMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
