using System;

namespace Table1
{
    public class CoffeeTable : Table
    {
        public CoffeeTable(int width,int height) : base(width,height)
        {
        }
        public override void ShowData()
        {
            Console.WriteLine($"A Coffeetable is allocated. Width is {width} and Height is { height }");

        }
    }
}
