using System;

namespace Human
{
    class Human
    {
        public string name;
        public int strength, intelligence, dexterity, health;

        public Human(string name)
        {
            this.name =name;
            strength =3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }
        
        public Human Attack(Human Target)
        {
            Target.health -= 5*strength;
            System.Console.WriteLine(($"{Target.name} was attacked. Health is now at {Target.health}"));
            return this;
        }

        public Human displayInfo()
        {
            Console.WriteLine($"name: {this.name}, strength: {strength}, intelligence: {intelligence}, dexterity: {dexterity}, health: {health}");
            return this;    
        }

        public override string ToString()
        {
            
            return 
                $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }

    }
}