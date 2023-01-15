using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarelagerProjekt {
    internal class Methods {

        #region Methods

        /// <summary>
        /// <br>Changes the color of the text according to what color you put in the string</br>
        /// <br>The code is based on Switch-statements - default is white.</br>
        /// <br></br>
        /// <br>Current added colors: Cyan, Yellow, Green, Red and White.</br>
        /// <br><br>Example: colorMethod("Cyan");</br></br>
        /// </summary>
        /// <param name="color"></param>
        public void colorMethod(string color)
        {
            switch (color) {
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        /// <summary>
        /// A method that defines CursorPosition while also changing the text color and writing a Console.WriteLine.
        /// <br><br>Requires 4 varibles: X-coordinate, Y-coordinate, "Color", "text-input"</br></br>
        /// <br>Example: postionText(10, 15, "Cyan", Hello World!)</br>
        /// </summary>
        /// <param name="lineX"></param>
        /// <param name="lineY"></param>
        /// <param name="text"></param>
        public void positionText(int lineX, int lineY, string color, string text)
        {
            colorMethod(color);
            Console.SetCursorPosition(lineX, lineY);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Draws a white herizontal line based on X and Y coordinates, which is written in the method.
        /// <br><br>Example: HorizontalLine(10, 15)</br></br>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void HorizontalLine(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < x; i++) {
                Console.SetCursorPosition(i, y);
                Console.Write("_");
            }
        }

        /// <summary>
        /// Draws a white vertical line based on X and Y coordinates, which is written in the method.
        /// <br></br>
        /// <br>Example: VerticalLine(15, 20);</br>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void VerticalLine(int x, int y )
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < y + 1; i++) {
                Console.SetCursorPosition(x, i);
                Console.Write("|");
            }
        }

        #endregion
    
    }
}
