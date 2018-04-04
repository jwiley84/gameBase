using System;

namespace gameProject
{   // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
    public class Human
    {
        public string charName { get; set; }
        public int health { get; set; }
        public int dexterity { get; set; }
        public int strength { get; set; } 

        public int intelligence  { get; set; }

        // Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.
        //  When an object is constructed from this class it should have the ability to pass a name

        public Human(string name) {
            this.health = 100;
            this.dexterity = 3;
            this.strength = 3;
            this.intelligence = 3;
            this.charName = name;

        }
        //  Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string name, int health, int dexterity, int strength, int intelligence) {
            this.charName = name;
            this.health = health;
            this.dexterity = dexterity;
            this.strength = strength;
            this.intelligence = intelligence;
        }
        //  Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).
        public Human Attack(Human opponent) {
            opponent.health -= (this.strength * 5);
            return this;
        }

        public Human AttackOpponent(object opponent) {
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
