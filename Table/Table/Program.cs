using System;


namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] randTable = new Table[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                randTable[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                randTable[i].showData();
            }
            Console.ReadLine();
        }

        class Table
        {
            float width;
            float height;

            public Table(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public float Width
            {
                set { width = value; }
                get { return width; }
            }
            public float Height
            {
                set { height = value; }
                get { return height; }
            }

            public void showData()
            {
                Console.WriteLine("Widht: {0}, Height: {1} ", width, height);
            }
        }
    }
}

