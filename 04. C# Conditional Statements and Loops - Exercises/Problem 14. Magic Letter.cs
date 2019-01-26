using System;

namespace TestApp
{
    class CountNums
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char controlChar = char.Parse(Console.ReadLine());


            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if (!(i== controlChar || j == controlChar || k == controlChar) )
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}