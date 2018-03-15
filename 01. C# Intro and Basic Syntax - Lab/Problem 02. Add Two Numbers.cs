using System;

namespace Homework
{
    class AddNumbers
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first} + {second} = {first + second}");
        }
    }
}
