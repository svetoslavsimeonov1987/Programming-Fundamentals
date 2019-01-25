using System;

namespace _01.HomeWork
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double singleRoomPrice = 0.0;
            double doubleRoomPrice = 0.0;
            double suiteRoomPrice = 0.0;
            

            if (month == "May" || month == "October")
            {
                singleRoomPrice = 50 * nights;
                doubleRoomPrice = 65 * nights;
                suiteRoomPrice = 75 * nights;
                //double singleNightDiscount = 50;
                if (nights > 7)
                {
                    singleRoomPrice = singleRoomPrice * 0.95;
                }
                
                if (nights > 7 && month == "October")
                {
                    singleRoomPrice -= (singleRoomPrice / nights);
                }
            }
            else if (month == "June" || month == "September")
            {
                singleRoomPrice = 60 * nights;
                doubleRoomPrice = 72 * nights;
                suiteRoomPrice = 82 * nights;
                double singleNightDiscount = 60;
                if (nights > 14)
                {
                    doubleRoomPrice = doubleRoomPrice * 0.9;
                }
                if (nights > 7 && month == "September")
                {
                    singleRoomPrice -= (singleRoomPrice / nights);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                singleRoomPrice = 68 * nights;
                doubleRoomPrice = 77 * nights;
                suiteRoomPrice = 89 * nights;
                if (nights > 14)
                {
                    suiteRoomPrice = suiteRoomPrice *0.85;
                } 
            }
            Console.WriteLine($"Studio: {singleRoomPrice:f2} lv.");
            Console.WriteLine($"Double: {doubleRoomPrice:f2} lv.");
            Console.WriteLine($"Suite: {suiteRoomPrice:f2} lv.");
        }
    }
}
