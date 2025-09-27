using Tyuiu.AytuvarovTK.Sprint1.Task7.V3.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AytuvarovTK.Sprint1.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Сприт #1 | Выполнил: Айтуваров Т. К. | ИСПБ-25-1";
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                                  *");
            Console.WriteLine("* Задание #7                                                                                                        *");
            Console.WriteLine("* Вариант #3                                                                                                        *");
            Console.WriteLine("* Выполнил: Айтуваров Т. К. | ИСПБ-25-1                                                                             *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,                      *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                                *");
            Console.WriteLine("*                                                                                                                   *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                  *");
            Console.WriteLine("* z = 3 + e ^ y - 1 / 1 + x ^ 2 | y = tg x |                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
