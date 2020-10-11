using System;

namespace FighterVideoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Character James = new Character("James", 100, 55, 5);
            Character Lizzie = new Character("Lizzie", 100, 50, 15);

            do
            {
                James.Attack(Lizzie.strength);
                Console.WriteLine("Lizzie attack James");
                Console.WriteLine(James.name + " has " + James.healthPoint + "HP left!");
                if (!James.IsAlive())
                {
                    Console.WriteLine("James Fainted !");
                    Console.WriteLine("Lizzie wins !");
                    break;
                }

                Lizzie.Attack(James.strength);
                Console.WriteLine("James attack Lizzie");
                Console.WriteLine(Lizzie.name + " has " + Lizzie.healthPoint + "HP left!");
                if (!Lizzie.IsAlive())
                {
                    Console.WriteLine("Lizzie Fainted !");
                    Console.WriteLine("James wins !");
                    break;
                }

            } while (James.IsAlive() && Lizzie.IsAlive());


        }
    }
}
