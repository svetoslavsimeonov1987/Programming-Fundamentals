using System;

namespace TestApp
{
    class CountNums
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool found = false;
            int firstResult = 0;
            int secondResult = 0;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    int sum = i + j;
                    combinations++;
                    if (sum == magicNumber)
                    {
                        found = true;
                        firstResult = i;
                        secondResult = j;
                    }
                }
            }
            if (found)
            {
                Console.WriteLine($"Number found! {firstResult} + {secondResult} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}