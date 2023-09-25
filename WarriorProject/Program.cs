/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    class Program
    {
        class Position
        {
            private int x;
            private int y;


            public int X { get => x; set=> x = value;  }
            public int Y { get => y; set => x = value; }

         
            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void ToConsole()
            {
                Console.WriteLine($"{this.x}, {this.y}");
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
