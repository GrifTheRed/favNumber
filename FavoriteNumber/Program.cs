using System;

namespace FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"guess my favoirte number");

            var r = new Random();
            var favNumber = r.Next(1,1000);

            var userInput = int.Parse(Console.ReadLine());

            

            if (userInput<favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput>favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("you got it!");
            }
        }
    }
}

