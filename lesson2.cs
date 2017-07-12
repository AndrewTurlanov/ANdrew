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
            int d = Convert.ToInt32(Console.ReadLine());

            if (d < 0)
            {
                Console.WriteLine("Отрицательное");
            }
            else if (d == 0)
            {
                Console.WriteLine("Равно 0");
            }

            else
            {
                Console.WriteLine("Положительно");
            }


        }
    }
}
