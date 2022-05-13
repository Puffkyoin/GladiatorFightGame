using System;
using System.Data;

namespace Gladiator_Fight
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int minHealth = 100;
            int maxHealth = 201;
            int minValue = 25;
            int maxValue = 50;
            int advantage = 25;
            int health1 = random.Next(minHealth, maxHealth);
            int damage1 = random.Next(minValue + advantage, maxValue + advantage);
            int armor1 = random.Next(minValue, maxValue);
            int health2 = random.Next(minHealth, maxHealth);
            int damage2 = random.Next(minValue, maxValue);
            int armor2 = random.Next(minValue + advantage, maxValue + advantage);
            int hitNumber = 0;
            int divider = 100;

            Console.WriteLine($"Гладиатор1: \nЗдоровье - {health1}\nЗашита - {armor1}\nАтака - {damage1}\n");
            Console.WriteLine($"Гладиатор2: \nЗдоровье - {health2}\nЗашита - {armor2}\nАтака - {damage2}\n");
            Console.WriteLine("Битва начинается!");
            Console.ReadKey();

            while (health1 > 0 && health2 > 0)
            {
                // формула health -= damage * (1 - armor / 100)
                health1 -= Convert.ToInt32(random.Next(0, damage2) * (1 - Convert.ToSingle(armor1 / divider)));
                health2 -= Convert.ToInt32(random.Next(0, damage1) * (1 - Convert.ToSingle(armor2 / divider)));
                Console.WriteLine($"Стычка №{++hitNumber}");
                Console.WriteLine($"Гладиатор1 - {health1} здоровья.");
                Console.WriteLine($"Гладиатор2 - {health2} здоровья.\n");
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья!");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Первый гладиатор пал!");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Второй гладиатор пал!");
            }
        }
    }
}