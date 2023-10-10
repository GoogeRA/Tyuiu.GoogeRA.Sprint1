using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoogeRA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.GoogeRA.Sprint1.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринтуФайл            *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение         *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("* x + e^x + ((sin(x^5)+x^3)/ 3^x) + (y^5 / 5^y)                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.Calculate(x, y);

            double result = Convert.ToDouble(res);

            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
