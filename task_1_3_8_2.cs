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
            Console.WriteLine("Введите пароль");
            string UserPassword = Console.ReadLine();
            string password = "pas2017";

            int i = 1;
          
            while (UserPassword != password)
            {
                
                i++;

                if (i <= 5)
                {
                    Console.WriteLine("Пароль неверный, попробуйте еще раз");
                    UserPassword = Console.ReadLine();
                }


                else
                {
                    
                    Console.WriteLine("Все попытки исчерпаны");
                    break;
                }

            }

            if (UserPassword == password)
            {
                Console.WriteLine("Вы увидели секретное сообщение");
            }

        }
    }
}
