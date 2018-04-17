using System;
using System.Collections.Generic;

namespace Wizard__Ninja__Samurai
{
    public class Ninja : Human {
        public Ninja(string person) : base (person){
            name = person;
            dexterity = 175;
        }
        public void stealth(object obj)
        {   
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.attack(enemy);
                health += 10;
            }
        }
        public void get_away()
        {
            Console.WriteLine("Escaping");
            health -= 15;
        }
    }
}