using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexExpr
{
    class Player
    {
        
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }

        public Player(string name, int health, int maxHealth, int energy, int maxEnergy)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Health = health;
            this.Energy = energy;
            this.MaxEnergy = maxEnergy;
        }
    }
    class Program
    {
        static void Main()
        {

            var firstPlayer = Console.ReadLine();
            var firstHealth = int.Parse(Console.ReadLine());
            var firstMaxHealth = int.Parse(Console.ReadLine());
            var firstEnergy = int.Parse(Console.ReadLine());
            var firstMaxEnergy = int.Parse(Console.ReadLine());

            var player = new Player(firstPlayer, firstHealth, firstMaxHealth, firstEnergy, firstMaxEnergy);

            Console.WriteLine($"Name: {player.Name}");
            Console.Write($"Health: |");
            for (int i = 0; i < player.MaxHealth; i++)
            {
                if (i < player.Health)
                {
                    Console.Write('|');
                   
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine('|');

            Console.Write($"Energy: |");
            for (int i = 0; i < player.MaxEnergy; i++)
            {
                if (i<player.Energy)
                {
                    Console.Write('|');
                    
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine('|');







        }
    }
}
