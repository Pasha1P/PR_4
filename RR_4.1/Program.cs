//************************
//*Проверочная Работа №4 *
//*Поогудин Павел 2ИСП   *
//************************



using System;


namespace RR_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №1 Погудин Павел";//оглавление

            double a, b, c, Y;                       
            double v1, v2, v3, v4, v5, v6, v7, v8;   

            Console.WriteLine("Здраствуйте!");       
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            v1 = b * c * c * c;                                                                             
            v1 = Math.Sqrt(Math.Sqrt(v1));            //расчет корня корня
            v2 = a * a * b * c;
            v2 = Math.Sqrt(Math.Sqrt(v2));            //расчет корня корня
            v3 = Math.Sqrt(a);                        //расчет корня для деления
            v4 = Math.Sqrt(c);                        //расчет корня для деления
            v5 = b * c;
            v5 = Math.Sqrt(Math.Sqrt(v5));            //расчет корня
            v5 = (v1 + v2) / (v3 + v4) + v5;
            v5 = v5 * v5;
            v6 = b * c;
            v7 = v5 - v6 + 12;  
            v8 = Math.Sqrt(v6);                       //расчет корня
            v8 -= 3;                                  //сахар
            Y = v7 / v8;  

            Console.WriteLine("Результат: Y={0:#.######}", Y);

            Console.ReadKey();
        }
    }
}
