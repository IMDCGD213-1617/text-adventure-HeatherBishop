using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class TextUtilities
    {
        //receive string of text from player

        //Extract Command()
        //e.g. Move
        public static string ExtractCommand(string line)
        {
            
            //space = seperation between command/argument
            //find space between words
            int index = line.IndexOf(' ');

            //if no space index == -1
            //return as command
            if (index == -1)
                return line;
            else
                return line.Substring(0, index); //start at beggining (0) of string, end at index.
        }

        //Extract Arguments()
        //e.g. North
        public static string ExtractArguments(string line)
        {
            int index = line.IndexOf(' '); //chars indicated by single quotes'', string double quotes ""

            if (index == -1)
                return "";
            else
                //if there was a space in previous line
                return line.Substring(index + 1, line.Length - index - 1); //(pos of space, +1 to ignore space and start at argument, 
                                                                           //how many characters until the end of the line? 
                                                                           //Overall length - index) 

        }

        //WordWrap()
        //Start new line of text
        //Prevent breaking words up to keep readability for player
        public static string WordWrap(string text, int bufferWidth)
        {
            return text;
        }
        
    }
}
