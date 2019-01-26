using System;

namespace TestApp
{
    class CountNums
    {
        static void Main()
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber = ulong.Parse(Console.ReadLine());
            ulong targetSum = ulong.Parse(Console.ReadLine());
            ulong totalCombinations = 0;
            ulong sum = 0;
            bool completed = false;
            for (ulong i = firstNumber; i > 0; i--)
            {
                if (completed)
                {
                    break;
                }
                for (ulong j = 1; j <= secondNumber; j++)
                {
                    sum += 3 * (i * j);
                    totalCombinations++;
                    if (sum >= targetSum)
                    {
                        completed = true;
                        break;
                    }
                }
            }

            if (sum >= targetSum)
            {
                Console.WriteLine($"{totalCombinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {targetSum}");
            }
            else
            {
                Console.WriteLine($"{totalCombinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            

        }
    }
}