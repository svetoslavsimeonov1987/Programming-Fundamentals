using System;

namespace _01.HomeWork
{

    class Program
    {
       
        static void Main(string[] args)
        {
            double countOfPeople = double.Parse(Console.ReadLine());
            string disscountPackage = Console.ReadLine();
            double disscountPrice = 0.0;
            int disscount = 0;
            string hall = string.Empty;
            double price = 0.0;
            bool deal = true;
            switch (disscountPackage)
            {
                case "Normal":
                    disscountPrice = 500;
                    disscount = 5;
                    break;
                case "Gold":
                    disscountPrice = 750;
                    disscount = 10;
                    break;
                default:
                    disscountPrice = 1000;
                    disscount = 15;
                    break;
            }
            if (countOfPeople <= 50)
            {
                hall = "Small Hall";
                price = ((2500 + disscountPrice) - ((2500 + disscountPrice) *disscount)/100);
            }
            else if(countOfPeople <= 100)
            {
                hall = "Terrace";
                price = ((5000 + disscountPrice) - ((5000 + disscountPrice) * disscount) / 100);
            }
            else if (countOfPeople <= 120)
            {
                hall = "Great Hall";
                price = ((7500 + disscountPrice) - ((7500 + disscountPrice) * disscount) / 100);
            }
            else
            {
                deal = false;
            }


            double result = price / countOfPeople;
            if (deal == true)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {result:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
