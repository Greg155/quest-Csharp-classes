using System;
using System.Collections.Generic;
using System.Text;

namespace FighterVideoGame
{
    class Character
    {
        public string name;
        public int healthPoint;
        public int strength;
        public int defense;

        public Character(string name, int healthPoint, int strength, int defense)
        {
            this.name = name;
            this.healthPoint = healthPoint;
            this.strength = strength;
            this.defense = defense;
        }

        public Boolean IsAlive()
        {
            if (healthPoint <= 0)
            {
                Console.WriteLine(name + " Ko");
                return false;
            }else{
                Console.WriteLine(name + " Still alive!");
                return true;
            }
            
        }

        public int Attack(int enemyAtk)
        {
            healthPoint = healthPoint - (enemyAtk - defense);
            if(healthPoint<= 0)
            {
                healthPoint = 0;
            }
            return healthPoint;
        }

    }
}
