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

            /*
              С помощью циклов организуйте обработку команд. В программе должны быть следующие команды: 
              SetName (устанавливает имя)
              DisplayName (запрашивает число, и выводит столько раз имя)
              SetColor (установка цвета фона консоли и символов) 
              DisplayBoxWithName (отображение полого квадрата из символов ‘#’ с надписью имени внутри)
              
               */

            
           
            DisplayName();
            DisplayBoxWithName();







        }


        static string SetName()
        {
            string name = "Петя";
            return name;
        }

        static void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

        }


        static void DisplayName()
        {
            SetColor();
            Console.WriteLine("Введите число");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)

            {
                Console.WriteLine("Здравствуй " + SetName());
            }

        }



        static void DisplayBoxWithName()
        {
           
            string line = "#";
            string nameLeft = "#  ";
            string nameRight = "  #";
            
           

            string user = nameLeft + SetName() + nameRight;
            int letters = user.Length;


            string lineMiddle = line.PadLeft(Convert.ToInt32(letters), ' ');
            lineMiddle = lineMiddle.Remove(0, 1).Insert(0, "#"); //промежуточные строки


            // если четное, добавляем слева пробел
            // 1 строка содержит имя, а сверху и слева должно быть одинаковое количество, т.е. число строк и столбцов соответствнно должно быть нечетное


            // из-за ширины символов, на выходе не квадрат :(

            if (letters % 2 == 0)
            {
                user = user.Insert(1, " ");
            }

            int half = (user.Length - 1) / 2;

            string lineFirst = line.PadLeft(Convert.ToInt32(user.Length), '#');  //первая и последняя строки
            
            
            // вывод квадрата

            Console.WriteLine(lineFirst);

            for (int i = 2; i <= half; i++)
            {
                Console.WriteLine(lineMiddle);
            }

            Console.WriteLine(user);


            for (int i = 2; i <= half; i++)
            {
                Console.WriteLine(lineMiddle);
            }

            Console.WriteLine(lineFirst);


            



            


        }




    }
}
