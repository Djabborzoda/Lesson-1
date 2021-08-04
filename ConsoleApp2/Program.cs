using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
                                           // Задача №1
            double a = 16.80;//#1
            double b = 12.40;
            Console.WriteLine(Math.Sqrt(a * b));
            
                                              //Задача №2
            double A = 1.40;
            double B =-5.50;
            double C = 0.60;
            double ac = A - C;
            double bc = C - B;
            
            Console.WriteLine("ас " + ac);
            Console.WriteLine("bc " + bc);
            Console.WriteLine("ac + ab = " + (ac+bc));
            
                                               //Задача №3
            double x1 = -6.20;
            double x2 = 2.10;
            double y1 = 5.20;
            double y2 = 9.80;
            Console.WriteLine( Math.Sqrt( Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)) ); 
            
             int ab =41;                       //Задача №4
             int ba =0;
             ba =ab/10 +ab%10*10;
             Console.Write(ba); 
            
                                             // Задача №5
            
            int N = 10985;      
            Console.WriteLine (N/60);

                                             // Задача № 6 
            
            int Воскресенье = 0;
            int Понедельник = 1;
            int Вторник = 2;
            int Суббота = 6;
            int K = 202;
            int result = K % 7;
            Console.WriteLine(result);




        }

        
    }
}