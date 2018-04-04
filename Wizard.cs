using System;

namespace gameProject
{   // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
    public class Wizard: Human
    {

        public Wizard(string name) : base(name) {
            this.intelligence = 25;
            this.charName = name;
            this.health = 50;

        }

        public void heal() {
            this.health += 10*intelligence;
        }
        public new Wizard Attack(Human opponent) {
            Random seed = new Random();
            int hits = seed.Next(20,50);            
            opponent.health -= hits;
            return this;
        }
        public Wizard fireball(object opponent) {
            if (opponent is Human) {
                this.Attack(opponent as Human);
            }
            else {
                Console.WriteLine("Stop attacking trees!");
            }
            return this;

        }
    }
}