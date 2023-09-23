﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GolubevDS.Sprint1.Task4.V2.Lib;

namespace Tyuiu.GolubevDS.Sprint1.Task4.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Голубев Д. С. | АСОиУБ 23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | АСОиУБ 23-2                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x, y;
            Console.WriteLine("Введите число Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 / ( x + 2 y ) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
