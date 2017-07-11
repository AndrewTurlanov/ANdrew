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
         
             byte variable_1 = 1;
             sbyte blom = -100;
             int ab = 10;
             long wep = 9999999;
             short q = 5000;
             decimal y = -79808000;            
             string _url = "http://www.yandex.ru";
             bool isOpen = false;
             var t = 150;
             var t1 = true;
           




             variable_1 = 1 + 1;
             blom = --blom;
             ab = ++ab;
             wep = 500000 + 50000;
             q = 9000 - 500;
             y = 79898989898 + 564354545364;
             _url = "new site:" + " http://www.google.com";
             isOpen = !isOpen;

             t = 150 * 2;
             t1 = true || false;
            

            
             int a = 10;                                 //10
             int b = 15 + 25;                            //40
             int c = a * b + 8;                          //408
             int d = (5 + 5) / 2;                        //5
             bool b_a = true;                            //true
             bool b_b = true && false;                   //false
             bool b_c = false || true;                   // true    
             bool b_d = true != false;                   //true
             bool b_e = b_a == b_c;                      // true
             string s = "test" + " " + "test2";          //test test2   
            

        }


    }
}
