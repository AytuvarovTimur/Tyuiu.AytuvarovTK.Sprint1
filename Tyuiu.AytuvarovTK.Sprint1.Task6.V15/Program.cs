using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AytuvarovTK.Sprint1.Task6.V15.Lib;

namespace Tyuiu.AytuvarovTK.Sprint1.Task6.V7
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
            Console.WriteLine("* Задание #6                                                                                                        *");
            Console.WriteLine("* Вариант #15                                                                                                       *");
            Console.WriteLine("* Выполнил: Айтуваров Т. К. | ИСПБ-25-1                                                                             *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                          *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке больше букв, чем знаков.                   *");
            Console.WriteLine("*                                                                                                                   *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                  *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();



            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Больше ли букв чем симбволов = " + ds.CheckLettersCount(str));

            Console.ReadKey();
        }
    }
}