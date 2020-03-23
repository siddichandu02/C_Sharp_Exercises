using System;

namespace Table1
{
    public class Table
    {
        protected int width, height;
        public Table(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public virtual void ShowData()
        {
            Console.WriteLine($"A table is allocated. Width is {width} and Height is { height }");

        }
    }
}
