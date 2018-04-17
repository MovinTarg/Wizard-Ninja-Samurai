using System;
using System.Collections.Generic;

namespace Wizard__Ninja__Samurai
{
    public class Samurai : Human {
        public static int instanceCount;
        public Samurai(string person) : base (person){
            name = person;
            health = 200;
            instanceCount = instanceCount + 1;
        }
        public void deathblow(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null || enemy.health > 49)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health = 0;
            }
        }
        public void meditate()
        {
            Console.WriteLine("Meditating");
            health = 200;
        }
        public void how_many()
        {
            Console.WriteLine("There are " + instanceCount + " Samurai!");
        }
    }
}