using Tyuiu.KhafizovTV.Sprint5.Task4.V6.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhafizovTV.Sprint5.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V6.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть             *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо *");
            Console.WriteLine("* Х в формуле                                                            *");
            Console.WriteLine("*              1                                                         *");
            Console.WriteLine("*      y = ---------- + 2.2x^2                                           *");
            Console.WriteLine("*            cos(x)                                                      *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх   *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}