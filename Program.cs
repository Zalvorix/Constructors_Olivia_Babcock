using System;

namespace Constructors_Olivia_Babcock
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Defines myGame values
            Game myGame = new Game("SW:KotOR", "RPG");

            // Prints myGame title and genre to the console
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre}! ");

            // Defines myOtherGame values
            Game myOtherGame = new Game();

            // Prints myOtherGame title and genre to the console
            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
