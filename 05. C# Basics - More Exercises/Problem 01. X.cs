using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(' ',i));
                Console.Write('x');
                Console.Write(new string(' ', n-2 - (i*2)));
                Console.Write('x');
                Console.WriteLine();
            }
            Console.Write(new string(' ', n/2));
            Console.WriteLine('x');
            //Console.WriteLine(new string(' ', n / 2));
            for (int i = n / 2, c = 0; i > 0; i--,c++) // i = 5; while i >= 0
            {
                
                Console.Write(new string(' ', i-1));
                Console.Write('x');
                Console.Write(new string(' ',(c*2) + 1));
                Console.Write('x');
                Console.Write(new string(' ',i));
                Console.WriteLine();
            }


        }
    }
}
