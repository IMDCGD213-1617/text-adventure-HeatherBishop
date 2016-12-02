using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {

        public static bool quitGame = false;
        static void Main(string[] args)
        {            
            //Call GameController to show the title screen.
            GameController.ShowTitleScreen();

            Level.Initialize(); //initialise level to create rooms

            GameController.StartGame(); //start the game so the player can play.

            //while the game is running
            while (!quitGame)
            {
                //read what the player has input, and apply it to CommandProccessor.
                CommandProcessor.ProcessPlayerCommand(Console.ReadLine());
            }
            

        }

    }
}
