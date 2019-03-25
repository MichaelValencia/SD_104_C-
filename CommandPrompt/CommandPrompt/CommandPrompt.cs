using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPrompt
{
    class CommandPrompt
    {
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;

        string[] screenText;
        int height;
        int columns;

        public CommandPrompt(int height, int columns)
        {
            backgroundColor = ConsoleColor.Red; // or whatever you like
            foregroundColor = ConsoleColor.Black; // orwhatever you like
            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 10);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        } // end of CommandPrompt constructor

        public void Display()
        {
            // set the foreground and background colors
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Clear();             //  the Console object is available to us to control aspects of our terminal window. The Clear method will blank our window
                                         // The Clear method has blanked the screen and left the cursor at the top of the window.
                                         // We will now loop through the screenText array to put out text on the screen.
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }   // end of Display method

        public void SetScreenText(int lineNumber, string lineText)
        {
            screenText[lineNumber] = lineText;
        }   // end of SetScreenText method

        public void ClearScreen()
        {
            Console.Clear();
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }// end of ClearScreen
        }
        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   // end of SetBackgroundColor

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        } // end of SetForegroundColor
        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;
                case "green": color = ConsoleColor.Green; break;
                case "blue": color = ConsoleColor.Blue; break;
                case "white": color = ConsoleColor.White; break;
                case "darkred": color = ConsoleColor.DarkRed; break;
                case "darkblue": color = ConsoleColor.DarkBlue; break;
                case "cyan": color = ConsoleColor.Cyan; break;
                case "darkgreen": color = ConsoleColor.DarkGreen; break;
                case "yellow": color = ConsoleColor.Yellow; break;


                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }   // end of ConvertColor method
    }//end of CommandPrompt class. all methods are define above here!!!
}//end of namespace


