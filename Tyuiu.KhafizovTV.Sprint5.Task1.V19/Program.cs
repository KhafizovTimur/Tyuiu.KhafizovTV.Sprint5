using Tyuiu.KhafizovTV.Sprint5.Task1.V19.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhafizovTV.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("*                                  2                                     *");
            Console.WriteLine("* Дана функция F(x) = sin(x) + -------- + 2cos(x) * 2x                   *");
            Console.WriteLine("*                               3x+0.5                                   *");
            Console.WriteLine("* (произвести табулирование) f(x) на                                     *");
            Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на    *");
            Console.WriteLine("* ноль. При делении на ноль вернуть значение 0. Результат сохранить в    *");
            Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.     *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}