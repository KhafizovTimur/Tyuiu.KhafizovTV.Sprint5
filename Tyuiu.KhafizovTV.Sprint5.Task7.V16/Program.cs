using Tyuiu.KhafizovTV.Sprint5.Task7.V16.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KhafizovTV.Sprint5.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V16.txt (файл взять из     *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку вручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор       *");
            Console.WriteLine("* символьных данных. Заменить все слова длиной 2 символа на слово \"XY\".*");
            Console.WriteLine("* Полученный результат сохранить в файл                                  *");
            Console.WriteLine("* OutPutDataFileTask7V16.txt.                                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            try
            {
                string path = @"C:\DataSprint5\InPutDataFileTask7V16.txt";

                if (!File.Exists(path))
                {
                    Console.WriteLine("Исходный файл не найден!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"Данные в файле {path}:");
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine("************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
                Console.WriteLine("************************************************************");

                string result = ds.LoadDataAndSave(path);
                string outputPath = @"C:\DataSprint5\OutPutDataFileTask7V16.txt";

                File.WriteAllText(outputPath, result);
                Console.WriteLine($"Результат сохранён в файле: {outputPath}");
                Console.WriteLine("Содержимое обработанного файла:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}