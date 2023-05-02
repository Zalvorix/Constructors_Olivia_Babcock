using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Olivia_Babcock
{
    class Game
    {
        public string title, genre;
        /// <summary>
        /// Defines Game string values
        /// </summary>
        /// <param name="titleParam"></param>
        /// <param name="genreParam"></param>
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {   
            title = titleParam;
            genre = genreParam;
        }
    }
}
