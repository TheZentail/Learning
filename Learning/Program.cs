using Learning;

Main();

// Point of entry for program
void Main()
{
    // Create a Player
    Player player = new() {
        Name = "Player Name",
        Money = 100
    };

    // Create an NPC
    AI randomCitizen = new() {
        Name = "Dean Winchester"
    };

    // just mess with the stats a little so they're not the default values
    player.SpendMoney(35);
    player.ModifyEnergy(-33);
    randomCitizen.ModifyEnergy(-15);
    randomCitizen.ModifyHunger(-94);

    // Display the stats of the player and the npc
    DisplayStats(player);
    DisplayStats(randomCitizen);

    // Display a conversation between the player and the npc
    DisplayRandomConversation(player, randomCitizen);

    // wait for input to exit
    Console.ReadKey();
}

void DisplayStats(Entity e) {
    Console.WriteLine("-----" + e.Name + "-----");
    Console.WriteLine("Hunger: " + e.Hunger);
    Console.WriteLine("Energy: " + e.Energy);

    if (e is Player) {
        Console.WriteLine("--Player Stats--");
        Console.WriteLine("Money: " + ((Player)e).Money);
    } else if (e is AI) {
        Console.WriteLine("--AI Stats--");
        Console.WriteLine("Behaviour: " + ((AI)e).Behaviour);
    }

    Console.WriteLine();
}

void DisplayRandomConversation(Entity person1, Entity person2) {
    person1.Speak("Hi there!");
    person2.Speak("Oh, hey! How are you doing?");
    person1.Speak("I'm doing great! How about yourself?");
    person2.Speak("Just fine!");
}