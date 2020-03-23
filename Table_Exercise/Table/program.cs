using System;
using System.Collections.Generic;
using System.Text;

namespace Table1
{
    class program
    {
        public static void Main(string[] args)
        {
            Table[] tables = new Table[10];
            Random random = new Random();
            for(int count = 1; count < 5; count++)
            {
                tables[count] = new CoffeeTable(random.Next(40, 121), random.Next(40, 121));
                tables[count].ShowData();
            }
            for (int count = 5; count < 10; count++)
            {
                tables[count] = new Table(random.Next(50, 201), random.Next(50, 201));
                tables[count].ShowData();
            }

        }
    }
}
