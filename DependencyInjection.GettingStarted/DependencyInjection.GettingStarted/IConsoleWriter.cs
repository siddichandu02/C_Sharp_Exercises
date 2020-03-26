using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.GettingStarted
{
    public interface IConsoleWriter
    {
        public void LogMessage(string message);
    }
}
