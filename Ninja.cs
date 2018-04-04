using System;

namespace gameProject
{   
    public class Ninja : Human
    {
        public Ninja(string name) : base(name) {
            this.strength = 2;
            this.dexterity = 175;
            
        }

        public string steal(object thing) {
            string wut = $"I stole the {thing}";
            Console.WriteLine($"I stole the {thing}");
            this.health += 10;           
            return wut;
        }

        public Ninja get_away() {
            this.health -= 15;
            return this;
        }

        
    }
}