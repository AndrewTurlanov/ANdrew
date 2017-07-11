using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1
{
    class Program
    {

        static int f = 80;

        static void Main(string[] args)
        {
            
             int a = 0;      //0
             int b = a;      //0    
             b = a++;        //0
             b = a;          //1
             b = ++a;        //2
             b = b++;        //2
             b = b++ + ++b;  //6

            
        }


    }
}
