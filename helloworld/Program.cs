using System;

namespace helloworld
{
    public class Program
    {
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
}
