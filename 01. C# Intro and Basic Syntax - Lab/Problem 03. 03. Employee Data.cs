using System;

namespace Homework
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = Console.ReadLine();
            var salary = double.Parse(Console.ReadLine());
            var idRes = id.PadLeft(8, '0');


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {idRes}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
