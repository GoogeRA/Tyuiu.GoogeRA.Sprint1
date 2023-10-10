using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint1.Task0.V1.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #1                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                           *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #1                                                 *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение            *");
            Console.WriteLine("* 36/2/9+1-6/2*3 и печатает результат на экране.             *");
            Console.WriteLine("*                                                            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* 36/2/9+1-6/2*3                                             *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();
        }
    }
}
