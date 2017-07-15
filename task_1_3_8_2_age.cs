using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите свой возраст");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= UserAge; i++)
            {
                Console.WriteLine("Поздравляю!");
            }
            

        }
    }
}
