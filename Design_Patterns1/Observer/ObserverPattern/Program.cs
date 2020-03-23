using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tSwift = new TSwift("1981 is now my favorite number.");

            var firstFan = new Fan("John");
            var secondFan = new Fan("Kate");

            tSwift.AddFollower(firstFan);
            tSwift.AddFollower(secondFan);

            tSwift.Tweet = "I love my new music.";

            Console.Read();
        }
    }
}
