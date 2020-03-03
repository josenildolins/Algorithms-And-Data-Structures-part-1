using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DependencyInjection.GettingStarted.DependencyInjection.GettingStarted;

namespace DependencyInjection.GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            // Register the CompositionRoot type with the container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            // This line is not a mistake.  Its intent is to contrast 
            // registering a component as Transient vs. Singleton.
            //
            // The prior example registered this type as a singleton,
            // now we're registering this type as a Transient so the 
            // output will show that new instances of ISingletonDemo are
            // created each time the dependency is fulfilled.
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>().LifestyleTransient());

            // Resolve an object of type ICompositionRoot (ask the container for an instance)
            // This is analagous to calling new() in a non-IoC application.
            var root = container.Resolve<ICompositionRoot>();

            root.LogMessage("Hello from my very first resolved class!");

            // Wait for user input so they can check the program's output.
            Console.ReadLine();

        }
    }
}
