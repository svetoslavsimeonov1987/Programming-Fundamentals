using System;

namespace _01.HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {count*0.7:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {count * 1.0:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {count * 1.7:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {count * 1.2:F2}.");
                    break;
            }
        }
    }
}
