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






            if (playerKey != ConsoleKey.Escape)
            {


                switch (playerKey)
                {
                    case ConsoleKey.W:
                        x++;
                        break;

                    case ConsoleKey.S:
                        x--;
                        break;

                    case ConsoleKey.D:
                        y++;
                        break;

                    case ConsoleKey.A:
                        y--;
                        break;

                }

               
               


                Console.WriteLine("X = " + x + ", Y = " + y);
                

            }
            



        }
    }
}
