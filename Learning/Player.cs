using System;

namespace Learning
{
    // Players are an Entity for the Player, but doesn't necessarily hold the same traits as other Entities (i.e. NPCs)
	public class Player : Entity
	{
        public int Money { get; set; } = 0;

        public Player() { }

        public void SpendMoney(int money) { Money -= money; }
        public void GainMoney(int money) { Money += money; }

        // this overwrites the ModifyHunger function from Entity so that it doesn't something else
        public override void ModifyHunger(int amount) {
            // base.ModifyHunger calls the ModifierHunger function that currently exists in the Entity class
            base.ModifyHunger(amount);
            // then it adds the extra stuff below

            if (amount > 0) {
                ModifyEnergy(amount / 5);
            }
        }

        // This overwrites the Speak function from Entity to instead say "You", as it's the player talking
        public override void Speak(string message) { Console.WriteLine($"You: {message}"); }
    }
}

