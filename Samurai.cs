using System;

namespace gameProject
{   // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
    public class Samurai: Human
    {
        public Samurai(string name) : base(name) {
            this.health = 200;
            this.strength = 4;
            this.dexterity = 2;
            this.charName = name;

        }

        public Samurai death_blow(Human opponent) {
            if (opponent is Human) {
                if (opponent.health <= 50) {
                    opponent.health = 0;
                }
                else {
                    Console.WriteLine("You missed!");
                }
            }
            else {
                Console.WriteLine("Stop attacking trees!");
            }
            
            return this;
        }

        public Samurai meditate() {
            this.health = 200;
            return this;
        }
    }
}