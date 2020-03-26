using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.GettingStarted
{
    public interface ICompositionRoot
    {
        public void LogMessage(string message);
    }
}
