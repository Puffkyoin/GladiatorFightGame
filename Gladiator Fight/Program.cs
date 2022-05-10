using System;
using System.Data;

namespace Gladiator_Fight
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            float health1 = rand.Next(90, 101);
            int damage1 = rand.Next(5, 21);
            int armor1= rand.Next(25, 66) ;
            float health2 = rand.Next(80, 151);
            int damage2 = rand.Next(25, 50);
            int armor2= rand.Next(15, 35);
            int hitNumber = 0 ;

            Console.WriteLine($"Гладиатор1: \nЗдоровье - {health1}\nЗашита - {armor1}\nАтака - {damage1}\n");
            Console.WriteLine($"Гладиатор2: \nЗдоровье - {health2}\nЗашита - {armor2}\nАтака - {damage2}\n");
            Console.ReadKey();

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;
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
            else if(health2 <= 0)
            {
                Console.WriteLine("Второй гладиатор повержен!");
            }
            
        }
    }
}