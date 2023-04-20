// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this program
namespace Constructors_Sadler_Madison
{
    // Other main class for the program
    class Game
    {
        // Creates public string for title and genre
        public string title, genre;

        // Sets public Game() with the default values "Unknown Title" for the titleParam and "Casual" for the genreParam
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            // Initializes title to titleParam
            title = titleParam;
            // Initializes genre to genreParam
            genre = genreParam;
        }
    }
}
