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
              Сделать метод DrawPyramid который принимает 1 параметр типа int size. 
              Результатом этого метода должна быть отрисованная в консоли пирамида размером size. 
            */

            DrawPyramid(6);                        
        }



        static void DrawPyramid(int size)
        {
           
            int rowOstatok, columnOstatok, rowStart, columnStart, maxRowDigit, maxColumnDigit;
           
            for (int i = 0; i < size; i++)
            {
                //столбцы

                for (int j = 0; j < size; j++)
                {
                    //строки
                    rowOstatok = size - i;
                    columnOstatok = size - j;

                    rowStart = i + 1;
                    columnStart = j + 1;

                    // до середины выбираем из мин. из rowStart,columnStart, потом идем вниз и уже смотрим  rowOstatok и columnOstatok                
                    maxRowDigit = Math.Min(rowStart, columnStart);
                    maxColumnDigit = Math.Min(rowOstatok, columnOstatok);
                    
                    Console.Write(Math.Min(maxRowDigit, maxColumnDigit));
                }

                Console.WriteLine();
            }            


        }               

        }        
}
