using System;

namespace Learning
{
	public class Entity
	{
        public string Name { get; set; } = "NoName";
        public int Hunger { get; set; } = 100;
        public int Energy { get; set; } = 100;

        public Entity() { }

        // All Entities can call these functions
        public void ChangeName(string name) { Name = name; }

        // virtual void functions are able to be left alone if desired, or can be overwritten in classes that inherit this class
        public virtual void ModifyHunger(int amount) { Hunger += amount; }
        public virtual void ModifyEnergy(int amount) { Energy += amount; }
        public virtual void Speak(string message) { Console.WriteLine(Name + ": " + message); }
	}
}

