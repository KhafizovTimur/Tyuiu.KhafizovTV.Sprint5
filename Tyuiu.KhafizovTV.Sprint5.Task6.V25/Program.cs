using Tyuiu.KhafizovTV.Sprint5.Task6.V25.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhafizovTV.Sprint5.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                       *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V25.txt (файл взять из     *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор       *");
            Console.WriteLine("* символьных данных. Найти количество знаков восклицания в заданной      *");
            Console.WriteLine("* строке.                                                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            try
            {
                int res = ds.LoadFromDataFile(path);
                Console.WriteLine("Количество знаков восклицания в заданной строке: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}