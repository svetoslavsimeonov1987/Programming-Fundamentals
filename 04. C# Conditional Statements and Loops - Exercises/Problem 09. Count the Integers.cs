using System;

namespace TestApp
{
    class CountNums
    {
        static void Main()
        {
            bool isInt = true;
            int countNumbers = 0;

            while (isInt)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    countNumbers++;

                }
                catch (Exception)
                {

                    isInt = false;
                }

            }
            Console.WriteLine(countNumbers);
        }
    }
}