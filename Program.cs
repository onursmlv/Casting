using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();

            eagle.Age = 35;

            Eagle eagle2 = new Eagle();
            eagle2.Age = 45;

            Eagle eagle3 = new Eagle();
            eagle3.Age = 50;

            Snake snake = new Snake();
            snake.Length = 10;

            Snake snake2 = new Snake();
            snake2.Length = 15;

            Snake snake3 = new Snake();
            snake3.Length = 25;

            Eagle[] eagles = new Eagle[] { eagle, eagle2, eagle3 };

            Snake[] snakes = new Snake[] { snake, snake2, snake3 };

            //foreach( Eagle item in Eagle.GetEagles(eagles))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //foreach (Snake item in Snake.GetEagles(snakes))
            //{
            //    Console.WriteLine(item.ToString());
            //}


            

            Animal[] animals = { snake, eagle2, snake2, eagle,eagle3,snake3 };

            //Tehlukeli yol
            //Eagle newEagle = (Eagle)animals[0];


            //Tehlukesiz yol
            // Animal is Eagle


            //Tehlukesiz yol
            // Animal as Eagle


            foreach (Animal animal in animals)
            {
                //Eagle eagle1 = animal as Eagle;
                //if(eagle1 != null)
                //{
                //    Console.WriteLine("Eaglein agei " + eagle1.ToString());
                //}
                //else
                //{
                //    Console.WriteLine("Snake uzunlugu " + newSnake.ToString());
                //}

                //if (animal is Eagle)
                //{
                //    Eagle newEagle = (Eagle)animal;
                //    Console.WriteLine("Eaglein agei " + newEagle.ToString());
                //}
                //else
                //{
                //    Snake newSnake = (Snake)animal;
                //    Console.WriteLine("Snake uzunlugu "+ newSnake.ToString());
                //}
            }




            //Console.WriteLine(Eagle.GetEagles(eagles).ToString());


            //Animal eagle1 = new Eagle();

            //Birds eagle2 = new Eagle();


            //Reptile reptile = new Snake();




        }
    }
}
