using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Snake : Reptile
    {
        public int Length { get; set; }

        public override void Move()
        {
            Console.WriteLine("Move as Snake");
        }

        public override void Voice()
        {
            Console.WriteLine("Voice as Snake");
        }


        public static Snake[] GetSnakes(Snake[] snakes)
        {
            Snake[] newSnakes = new Snake[0];

            foreach (Snake item in snakes)
            {
                if (item.Length > 12)
                {
                    Array.Resize(ref newSnakes, newSnakes.Length + 1);
                    newSnakes[newSnakes.Length - 1] = item;
                }
            }
            return newSnakes;
        }


        public override string ToString()
        {
            return $"{this.Length}";
        }
    }
}
