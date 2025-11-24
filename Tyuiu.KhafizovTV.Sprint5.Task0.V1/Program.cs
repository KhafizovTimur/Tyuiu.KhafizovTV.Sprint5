using Tyuiu.KhafizovTV.Sprint5.Task0.V1.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дано выражение F(x) = x^3 + 2x^2 + 5x + 4, вычислить его значение      *");
            Console.WriteLine("* при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и  *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}