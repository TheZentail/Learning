using System;

namespace Learning
{
	// AI is an Entity for NPCs, but doesn't necessarily hold the same traits as a Player
	public class AI : Entity
	{
        public AIBehaviour Behaviour { get; set; } = AIBehaviour.PASSIVE;

        public AI() { }
	}
}

