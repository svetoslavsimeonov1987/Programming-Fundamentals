using System;

namespace HomeworkConditionalStatements
{

    class PassedFailed
    {
        static void Main()
        {
            var input = double.Parse(Console.ReadLine());

            if (input >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}