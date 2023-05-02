using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Jefferson
{
    abstract class Game
    {
        /// <summary>
        /// creates a background field for the title and esrb 
        /// </summary>
        public string Esrb { get; set; }

        public string Title { get; set; }

        //provides a value to initialize Esrb and Title.
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }
        /// <summary>
        /// Prints the title and says it is starting.
        /// </summary>
        public void playGame()
        {
            Console.WriteLine($"{Title} is starting!");
        }

        //a string that is abstract.
        public abstract string Describe();
    }
}
