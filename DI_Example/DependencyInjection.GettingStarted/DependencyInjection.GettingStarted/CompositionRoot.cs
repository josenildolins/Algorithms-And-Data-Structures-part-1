using System;

namespace DependencyInjection.GettingStarted
{
    //  --------------------------------------------------------------------------------------
    // DependencyInjection.GettingStarted.CompositionRoot.cs
    // 2017/01/11
    //  --------------------------------------------------------------------------------------

    namespace DependencyInjection.GettingStarted
    {
        public class CompositionRoot : ICompositionRoot
        {
            private readonly IConsoleWriter consoleWriter;
            private readonly ISingletonDemo singletonDemo;


            public CompositionRoot(IConsoleWriter consoleWriter, ISingletonDemo singletonDemo)
            {
                this.consoleWriter = consoleWriter;
                this.singletonDemo = singletonDemo;
                consoleWriter.LogMessage("Hello from CompositionRoot Constructor!");
            }
            
            public void LogMessage(string message)
            {
                var msg = $"CompositionRoot.LogMessage:  singletonDemo.ObjectId={singletonDemo.ObjectId}";
                consoleWriter.LogMessage(msg);
                Console.WriteLine(message);
            }

        }
    }
}
