using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class TextBuffer
    {
        private static string outputBuffer;


        // Dump all text here, prepared to put it to monitor screen.

        // Add Text To Buffer()
        public static void Add(string text)
        {
            //internal output buffer
            //add output text
            outputBuffer += text + "\n";
        }

        // Display Text In Buffer()
        public static void DisplayText()
        {
            //clear scren
            Console.Clear();
            //write out output buffer
            Console.Write(TextUtilities.WordWrap(outputBuffer, Console.WindowWidth));

            //what sould I do?
            Console.WriteLine("\nWhat shall I do?");

            //add character to make buffer look nicer
            Console.Write(">");

            //because we have run a dislay, clear display
            outputBuffer = "";
        }
    }
}
