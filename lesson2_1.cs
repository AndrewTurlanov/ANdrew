using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKey playerKey = Console.ReadKey(true).Key;
            int x = 0, y = 0;

            while (playerKey == ConsoleKey.Escape)
            {

                if (playerKey == ConsoleKey.W)
                {
                    x++;
                }

                else if (playerKey == ConsoleKey.S)
                {
                    x--;
                }

               else if (playerKey == ConsoleKey.D)
                {
                    y++;
                }

                else if (playerKey == ConsoleKey.A)
                {
                    y--;
                }


                Console.WriteLine("X=" + x + ", Y=" + y);

            }


        }
    }
}
