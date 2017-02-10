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


            Console.WriteLine("\nYou have been tasked to work late and finish off some paperwork.");
            Console.WriteLine("\nMost of your collegues have already left.");
            Console.WriteLine("\nOnly a few loyal friends remain, but the mood is quickly becoming sour.");
            Console.WriteLine("\nThe thought of facing them is unbearable.");
            Console.WriteLine("\nUnfortunately, your pen has run out and you have no stapler or envelopes left.");
            Console.WriteLine("\nWithout them, there is no hope you will finish your work before the Boss gets back in the morning.");
            Console.WriteLine("\nAquire the items BLACK PEN, STAPLER, MANILLA ENVELOPE.");
            Console.WriteLine("\nNOTE: If you are stuck at any time, type HELP to see a list of commands.");
            Console.WriteLine("\nIf there is no text on the screen, type LOOK or EXAMINE.");
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


            //if the 4 items are in your office.
            //end game
            if (Level.Room[0, 0].GetItem("Black Pen") != null && Level.Room[0, 0].GetItem("Manilla Envelope") != null && Level.Room[0, 0].GetItem("Stapler") != null) 
            {
                EndGame("Congratulations, you have aquired all of items and can complete your work in time!");
            }

            //if the player has the red pen 
            if (Player.GetInventoryItem("red pen") != null)
            {
                // add an exit to Georges office.
                Level.Room[0, 1].AddExit(Direction.East); //add east direction to 0,1 to enter georges office
                    Level.Room[0,2].AddExit(Direction.West); // add west direction to return to original location [0,1]          
                Level.Room[0, 2].RoomDescription = "George spots the RED PEN in your hand, and asks if he can have it in exchange for a STAPLER.";
                //if player puts pen in x 0, y 2
                if (Player.PosX == 0 && Player.PosY == 2)
                {
                    Player.DropItem("red pen");
                    Level.Room[0, 2].RoomDescription = "Having given George the RED PEN he is now scribbling desperately on spreadsheets. He doesnt even look up when you enter the room.";
                    
                }
            }


            

            
            //if player has the basement key or paper clip
            if (Player.GetInventoryItem("Basement Key") != null || Player.GetInventoryItem("Paper Clip") != null)
            {
                //add an exit to the south so player can now enter the basement
                Level.Room[4, 1].AddExit(Direction.South);

                //change the description to show something has changed/access the castle
                Level.Room[5, 1].RoomDescription = "You have entered the basement. The smell of damp permiates the air.";
            }
            

            if (Player.Moves > 25)
            {
                EndGame("You have run out of moves. Morning breaks and your Boss has arrived. \nHaving not completed your work he mercilessly fires you.");
            }
        }

    }
}
