using System;

namespace TestApp
{
    class FromToNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = Math.Min(firstNumber,secondNumber); i <= Math.Max(firstNumber,secondNumber); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}