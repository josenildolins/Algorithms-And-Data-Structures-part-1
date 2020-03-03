using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.GettingStarted
{
    public class ConsoleWriter : IConsoleWriter
    {
        private readonly ISingletonDemo singletonDemo;
        public ConsoleWriter(ISingletonDemo singletonDemo)
        {
            this.singletonDemo = singletonDemo;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine("ConsoleWriter.LogMessage:  singletonDemo.ObjectId = {0}",
                singletonDemo.ObjectId);
            Console.WriteLine(message);
        }
    }

}
