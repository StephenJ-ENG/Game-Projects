using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Adventure;

namespace Text_Adventure
{
    public class UI
    {
        public static void PrintCentered(string text)
        {
            // calculate the center position of the console window
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            int x = (width / 2) - (text.Length / 2);
            int y = height / 2;

            // set the cursor position to the top left corner of the box
            int boxWidth = text.Length + 4;
            int boxHeight = 3;
            int boxX = (width / 2) - (boxWidth / 2);
            int boxY = y - (boxHeight / 2);
            Console.SetCursorPosition(boxX, boxY);

            // draw the top border of the box
            Console.Write("+");
            Console.Write(new string('-', boxWidth - 2));
            Console.Write("+");

            // draw the middle border and text of the box
            Console.SetCursorPosition(boxX, boxY + 1);
            Console.Write("|");
            Console.Write(new string(' ', boxWidth - 2));
            Console.Write("|");
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            Console.SetCursorPosition(boxX, boxY + 2);
            Console.Write("|");
            Console.Write(new string('-', boxWidth - 2));
            Console.Write("|");

            // draw the bottom border of the box
            Console.SetCursorPosition(boxX, boxY + 3);
            Console.Write("+");
            Console.Write(new string('-', boxWidth - 2));
            Console.Write("+");
        }


    }
}
