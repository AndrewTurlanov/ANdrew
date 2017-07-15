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
             Подумайте когда лучше использовать цикл for а когда while. 
             И приведите наилучший пример использования того и того цикла. 
            
             for - цикл, куда можем передавать параметр. Задаются начальное и конечное значение.
             while - цикл пока соответствует условию. Можем не знать конечное кол-во действий в цикле

             
             */

            int sum = 0, count = 5, start = 1;

            for (int j = start; j <= count; j++)
            {
                sum += j;
            }
            Console.WriteLine("Сумма всех элементов c " + start + " до " + count + " = " + sum);




            Console.WriteLine("Введите код");

            string UserAge = Console.ReadLine();
            int k = 1;
           
            while (UserAge!="code")
            {
                Console.WriteLine("Неверный код, попытка " + k);
                UserAge = Console.ReadLine();
                k++;
            }


           
        }
    }
}
