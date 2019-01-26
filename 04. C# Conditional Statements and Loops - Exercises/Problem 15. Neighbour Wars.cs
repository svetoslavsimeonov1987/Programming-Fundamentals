using System;

namespace TestApp
{
    class CountNums
    {
        static void Main()
        {

            int peshoHealth = 100;
            int goshoHealth = 100;
            
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            bool isDead = false;
            
            string winner = string.Empty;
            int rounds = 0;
            while (!isDead)
            {
                rounds++;
                if (rounds % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        winner = "Pesho";
                        isDead = true;
                        break; ;
                        
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        winner = "Gosho";
                        isDead = true;
                        break;
                        
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                
                
                if (rounds % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                
            }

            Console.WriteLine($"{winner} won in {rounds}th round.");

        }
    }
}