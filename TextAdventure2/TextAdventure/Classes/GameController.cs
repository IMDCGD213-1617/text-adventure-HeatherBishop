using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class GameController // Only need one GameController
                                // Dont have to make a copy of GameManager in game
                                //Cannot change anything from another class, but can access methods from this class.
    {
        //Public Methods
        public static void ShowTitleScreen() //must be static as well as Class.
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(TextUtilities.WordWrap(("*** Welcome to Working Late! ***\n\n\n"), Console.WindowWidth));


            Console.WriteLine("\nYou are working late finishing off some paperwork.");
            Console.WriteLine("\nMost of your collegues have already left.");
            Console.WriteLine("\nUnfortunately you're pen has run out, you have no stapler or envelopes.");
            Console.WriteLine("\nTo finish you're work before the Boss gets back in the morning,");
            Console.WriteLine("\nAquire the items BLACK PEN, STAPLER, MANILLA ENVELOPE.");
            Console.WriteLine("\nNOTE: If you are stuck at any time, type HELP to see a list of commands.");
            Console.WriteLine("\nPress any key to begin.");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        //Start Game()
        //Tells player what room they are in.
        //Display the level.
        public static void StartGame()
        {
            Player.GetCurrentRoom().DescribeRoom();
            TextBuffer.DisplayText();
        }


        //End Game() takes string for end text, so we can reuse the same text even if there are different texts as we can pass it as an argument
        //Mark program as ready to quit.
        //Show final ending message.
        //Prevent any further input
        public static void EndGame(string endText)
        {
            Program.quitGame = true;

            Console.Clear();

            Console.WriteLine(TextUtilities.WordWrap(endText, Console.WindowWidth));

            //must close game by hitting close button
            //prevents accidental exit where player misses ending text
            Console.WriteLine("\nYou can now close this window.");
            Console.CursorVisible = false;

            //prevent further input
            while (true)            
                Console.ReadKey(true); //read key will look for key, but not show it when its pressed.
            
        }

        //Apply Rules()
        //checks for conditions being met.
        //adds items/doors/rooms and checks.
        public static void ApplyRules()
        {


            if (Level.Room[0, 0].GetItem("Black Pen") != null && Level.Room[0, 0].GetItem("Manilla Envelope") != null && Level.Room[0, 0].GetItem("Black Pen") != null) 
            {
                EndGame("Congratulations, you have aquired all of the treasures and completed your quest!");
            }


            //if the 4 treatures are in the house.

            //end game
            //if player has the basement key
            if (Player.GetInventoryItem("Basement Key") != null)
            {
                //add an exit to the south so player can now enter the basement
                Level.Room[4, 1].AddExit(Direction.South);

                //change the description to show something has changed/access the castle
                Level.Room[1, 0].RoomDescription = "You have entered the castle";
            }
            
            //add conditions for items that can only be obtained if another item is in the inventory.

            if (Player.Moves > 25)
            {
                EndGame("You have run out of moves. Its the morning, you're Boss has arrived. \nHaving not completed your work he mercilessly fires you.");
            }
        }

    }
}
