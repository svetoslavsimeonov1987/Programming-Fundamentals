using System;

namespace HomeworkConditionalStatements
{

    class Passed
    {
        static void Main()
        {
            var input = double.Parse(Console.ReadLine());

            if (input >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}