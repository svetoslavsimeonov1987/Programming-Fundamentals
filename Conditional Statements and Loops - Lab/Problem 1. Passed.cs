using System;

namespace HomeworkConditionalStatements
{

    class PassedProblem
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