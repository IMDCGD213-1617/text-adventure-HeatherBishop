using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
   static class CommandProcessor
    {



        //ProccessPlayerCommand()
        //Take line of text from player
        //break into two sections:
        //Command: Which command is it? Is it valid? Do something e.g Move
        //Arguments e.g. North
        public static void ProcessPlayerCommand(string line)
        {


            //text from player, store into variables.
            string command = TextUtilities.ExtractCommand(line.Trim()).Trim().ToLower(); //trims string to avoid command confusion with upper case/spaces
            string arguements = TextUtilities.ExtractArguments(line.Trim()).Trim().ToLower();

            //what command is it?
            switch (command)
            {
                case "exit":
                    Program.quitGame = true;
                    return;

                case "quit":
                    Program.quitGame = true;
                    return;

                case "q":
                    Program.quitGame = true;
                    return;

                case "help":
                    ShowHelp();
                    break;   //break out of switch before checking for other cases

                case "move":
                    Player.Move(arguements);
                    break;

                case "go":
                    Player.Move(arguements);
                    break;

                case "walk":
                    Player.Move(arguements);
                    break;

                case "look":
                    Player.GetCurrentRoom().DescribeRoom();                   
                    break;

                case "examine":
                    Player.GetCurrentRoom().DescribeRoom();
                    break;

                case "pickup":
                    Player.PickUpItem(arguements);
                    break;

                case "take":
                    Player.PickUpItem(arguements);
                    break;

                case "grab":
                    Player.PickUpItem(arguements);
                    break;

                case "drop":
                    Player.DropItem(arguements);
                    break;

                case "use":
                    Player.DropItem(arguements);
                    break;

                case "inventory":
                    Player.DisplayInventory();
                    break;

                case "whereami":
                    Player.GetCurrentRoom().ShowTitle();
                    break;
                case "location":
                    Player.GetCurrentRoom().ShowTitle();
                    break;
                case "coffee":
                    Level.AmendKitchen();
                    Player.GetCurrentRoom().DescribeRoom();
                    break;

                default:
                    TextBuffer.Add("I don't understand what you mean, type 'help' for some help");
                    break;
            }

            //apply game rules, has win condition been met? Has the game state changed?
            GameController.ApplyRules();

            //take text buffer and display info
            TextBuffer.DisplayText();


        }

        //Help screen
        public static void ShowHelp()
        {
            TextBuffer.Add("Available Commands:");
            TextBuffer.Add("--------------------");
            TextBuffer.Add("help");
            TextBuffer.Add("exit");
            TextBuffer.Add("move[north,south,east,west]");
            TextBuffer.Add("pickup");
            TextBuffer.Add("drop");
            TextBuffer.Add("look");
            TextBuffer.Add("inventory");
            TextBuffer.Add("whereami");
        }
            

    }
}
