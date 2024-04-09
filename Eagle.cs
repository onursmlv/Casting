using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Eagle : Birds
    {

        public int Age { get; set; }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public override void Voice()
        {
            Console.WriteLine("Voice as Eagle");
        }



        public static Eagle[] GetEagles(Eagle[] eagles)
        {
            Eagle[] newEagles = new Eagle[0];

            foreach(Eagle item in eagles)
            {
                if (item.Age > 40)
                {
                    Array.Resize(ref newEagles, newEagles.Length + 1);
                    newEagles[newEagles.Length - 1] = item;
                }
            }
            return newEagles;
        }

        public override string ToString()
        {
            return $"{this.Age}";
        }
    }
}
