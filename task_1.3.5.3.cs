using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1
{
    class Program
    {     

        static void Main(string[] args)
        {           

            int column = 3;
            int count = 52;
            int row =  count / column;

           Console.WriteLine("Полностью заполненных рядов: "+ row +", лишних картинок: " + (count - row * column));


        }


    }
}
