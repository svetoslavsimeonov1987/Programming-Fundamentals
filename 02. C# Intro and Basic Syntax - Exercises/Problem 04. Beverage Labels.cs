using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExpr
{
    class Program
    {
        static void Main()
        {
            
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            Console.WriteLine(${volume}ml {name});
            Console.WriteLine(${(energy  volume)100}kcal, {(volume  sugar)100}g sugars);

        }
    }
}
