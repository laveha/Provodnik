using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provodnik
{
    internal class Strelki
    {

        public static int Strelochki(int min, int max)
        {
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != min)
                {
                    pos--;
                    if (pos == min)
                        pos = max - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                    if (pos == max)
                        pos = min + 1;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -2;
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}