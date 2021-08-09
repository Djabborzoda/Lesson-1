using System;

namespace First_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
                                   //Task №1 
            double a = 16.8; 
            double b = 12.4;
            double k = Math.Sqrt(a*b);
            Console.WriteLine(k);
                                   //Task №2
            double A = 1.4;
            double B = -5.5;
            double  C = 0.6; 
            double AC = A - C;
            double BC = C - B;
            Console.WriteLine(AC);
            Console.WriteLine(BC);
            Console.WriteLine(AC+BC);
                                     //Task №3
            double x1 = -6.2;
            double x2 = 2.1;
            double y1 = 5.2;
            double y2 = 9.8;
            double h = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine(h);
                                    //Task №4
            int n = 41;
            int w = n / 10;
            int u = n % 10;
            Console.WriteLine(u+""+w);
                                   //Task №5
            int g = 10985;
            int m = g / 60;
            Console.WriteLine(m);
                                  //Task №6
            int Sunday = 0; 
            int Monday = 1;
            int Thuesday = 2;
            int Saturday = 6;
            int K = 202;
            int result = K % 7;
            Console.WriteLine(result);
        }
    }
}
