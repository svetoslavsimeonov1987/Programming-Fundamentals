using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 1.60934D;
            double result = a * b;

            Console.WriteLine($"{result:F2}");
        }
    }
}