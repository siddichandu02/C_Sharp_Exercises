using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // Concrete Observer
    public class Fan : IFan
    {
        private string name;

        public Fan(string name)
        {
            this.name = name;
        }
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan {this.name} notified. Tweet of {celebrity.FullName}: " +
                $"{celebrity.Tweet}");
        }
    }
}
