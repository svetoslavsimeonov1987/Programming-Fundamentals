using System;

namespace HomeworkConditionalStatements
{

    class Passed
    {
        public static object BigDecimal { get; private set; }

        static void Main()
        {
            
            double allMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double blasters10 = (priceLightsabers * 10)/ 100;
            int freeBelts = students / 6;

            double result = Math.Ceiling((priceLightsabers * (students + blasters10))) + (priceOfRobes * students) + (priceOfBelts * (students - freeBelts));

            Console.WriteLine(result);
        }
    }
}