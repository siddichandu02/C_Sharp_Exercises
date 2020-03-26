using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.GettingStarted
{
    class ConsoleWriter : IConsoleWriter
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
