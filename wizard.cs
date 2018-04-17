using System;
using System.Collections.Generic;

namespace Wizard__Ninja__Samurai
{
    public class Wizard : Human {
        public Wizard(string person) : base (person){
            name = person;
            intelligence = 25;
            health = 50;
        }
        public void heal()
        {
            Console.WriteLine("Healing");
            health += intelligence * 10;
        }
        public void fireball(object obj)
        {
            Random rand = new Random();
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= rand.Next(20, 50);
            }
        }
    }
}