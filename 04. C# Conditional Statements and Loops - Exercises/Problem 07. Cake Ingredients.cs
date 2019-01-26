using System;

namespace TestApp
{
    class Baker
    {
        static void Main()
        {
            int ingredientsAdded = 0;
            string input = Console.ReadLine();
            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                ingredientsAdded++;
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Preparing cake with {ingredientsAdded} ingredients.");
        }
    }
}