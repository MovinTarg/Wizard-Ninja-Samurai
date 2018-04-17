using System;
using System.Collections.Generic;

namespace Wizard__Ninja__Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human human1 = new Human("Blue");
            // Console.WriteLine("------------");
            // Console.WriteLine(human1.name);
            // Console.WriteLine(human1.strength);
            // Console.WriteLine(human1.intelligence);
            // Console.WriteLine(human1.dexterity);
            // Console.WriteLine(human1.health);
            // Human human2 = new Human("Red");
            // Console.WriteLine("------------");
            // Console.WriteLine(human2.name);
            // Console.WriteLine(human2.strength);
            // Console.WriteLine(human2.intelligence);
            // Console.WriteLine(human2.dexterity);
            // Console.WriteLine(human2.health);
            // human1.attack(human2);
            // Console.WriteLine("------------");
            // Console.WriteLine(human2.health);
            Wizard wizard1 = new Wizard("Gandolf");
            // Console.WriteLine("------------");
            // Console.WriteLine(wizard1.name);
            // Console.WriteLine(wizard1.strength);
            // Console.WriteLine(wizard1.intelligence);
            // Console.WriteLine(wizard1.dexterity);
            // Console.WriteLine(wizard1.health);
            // wizard1.heal();
            // Console.WriteLine(wizard1.health);
            Ninja ninja1 = new Ninja("Gaiden");
            // Console.WriteLine("------------");
            // Console.WriteLine(ninja1.name);
            // Console.WriteLine(ninja1.strength);
            // Console.WriteLine(ninja1.intelligence);
            // Console.WriteLine(ninja1.dexterity);
            // Console.WriteLine(ninja1.health);
            Samurai samurai1 = new Samurai("Jack");
            // Console.WriteLine("------------");
            // Console.WriteLine(samurai1.name);
            // Console.WriteLine(samurai1.strength);
            // Console.WriteLine(samurai1.intelligence);
            // Console.WriteLine(samurai1.dexterity);
            // Console.WriteLine(samurai1.health);
            wizard1.fireball(samurai1);
            // ninja1.stealth(samurai1);
            Console.WriteLine("------------");
            Console.WriteLine(samurai1.name);
            Console.WriteLine(samurai1.health);
            // ninja1.get_away();
            // Console.WriteLine("------------");
            // Console.WriteLine(ninja1.name);
            // Console.WriteLine(ninja1.health);
            // samurai1.attack(wizard1);
            // samurai1.deathblow(wizard1);
            // Console.WriteLine("------------");
            // Console.WriteLine(wizard1.name);
            // Console.WriteLine(wizard1.health);
            samurai1.meditate();
            Console.WriteLine("------------");
            Console.WriteLine(samurai1.name);
            Console.WriteLine(samurai1.health);
            samurai1.how_many();
        }
    }
}
