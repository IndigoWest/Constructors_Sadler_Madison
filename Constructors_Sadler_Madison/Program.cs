// System namespace needed to use Console class
using System;

// My collection of classes for this project
namespace Constructors_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Creates myGame under the class Game and initializes it to "Undertale" as the title and "RPG" as the genre
            Game myGame = new Game("Undertale", "RPG");

            // Prints text to the Console asking the user if they've heard of the title of myGame and tells the user that other users told it that it was a great game from the genre of myGame
            Console.WriteLine($"Have you heard of {myGame.title}? I'm told by users that it is a great {myGame.genre} game.");

            // Creates myGame2 under the class Game, but is not initialized
            Game myGame2 = new Game();

            // Prints text to the Console telling the user it's been told about the title of myGame2 and that it is only a genre of myGame2
            Console.WriteLine($"I've also been told about {myGame2.title}, and it is only a {myGame2.genre} game.");
        }
    }
}
