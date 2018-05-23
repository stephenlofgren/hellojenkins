using System;
using Microsoft.Extensions.DependencyInjection;
namespace helloworld
{
    public class Program
    {
        private static IServiceProvider Services { get; set; }
        
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            Program application = new Program(serviceCollection);
            WriteMessage(CreateMessage());
        }

        public Program(IServiceCollection serviceCollection)
        {
            ConfigureServices(serviceCollection);
            Services = serviceCollection.BuildServiceProvider();
            WriteMessage(CreateMessage());
        }

        static private void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMessageWriter, ConsoleMessageWriter>();
        }
        public static void WriteMessage(string message)
        {
            Services.GetRequiredService<IMessageWriter>().WriteMessage(message);
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

    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
