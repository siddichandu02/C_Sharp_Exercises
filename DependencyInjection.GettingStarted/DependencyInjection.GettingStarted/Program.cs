﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace DependencyInjection.GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            //Register the CompositionRoot type with the Container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());


            //Resolve an object of type ICompositionRoot(ask the container for an instance)
            // This is analagous to calling new() in a non-IoC application.
            var root = container.Resolve<ICompositionRoot>();

            root.LogMessage("Hello from my very first resolved class!");

            // Wait for user input so they can check the program's output.
            Console.ReadLine();
        }
    }
}
