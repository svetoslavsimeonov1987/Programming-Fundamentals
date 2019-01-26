using System;

namespace TestApp
{
    class Calories
    {
        static void Main(string[] args)
        {
            ulong calories = 0;

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}