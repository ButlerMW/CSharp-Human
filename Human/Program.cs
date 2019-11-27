using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health {get;set;}
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        // add a public "getter" property to access health
        //ass a constructor thaty takes a value to se NAme, and set the remaining fields to default values
        //add a constructor to assign custon values to all feilds
        //build attack method
        public int Attack(Human target)
        {
            target.Health -= 5 * Strength;
            Console.WriteLine($"{target.Name} loses {5 * Strength} Health!");
            return target.Health;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human daryl = new Human("Daryl");
            Console.WriteLine(daryl);
            daryl.Attack(daryl);
        }
    }
}
