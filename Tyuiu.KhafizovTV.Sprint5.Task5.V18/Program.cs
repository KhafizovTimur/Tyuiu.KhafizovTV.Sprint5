using Tyuiu.KhafizovTV.Sprint5.Task5.V18.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhafizovTV.Sprint5.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V18.txt (файл взять из       *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть               *");
            Console.WriteLine("* набор значений. Найти произведение всех двузначных чисел в файле.      *");
            Console.WriteLine("* Полученный результат вывести на консоль.                               *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V18.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            try
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine("Произведение всех двузначных чисел в файле: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}