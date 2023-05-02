using System;

namespace Inheritance_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //giving myFPS a value and giving words to values.
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.playGame();

            //giving csGo a value and giving words a value.
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.playGame();

        }
    }
}
