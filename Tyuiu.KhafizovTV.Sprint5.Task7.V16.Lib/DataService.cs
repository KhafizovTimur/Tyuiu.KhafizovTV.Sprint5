using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            string result = Regex.Replace(content, @"\b\w{2}\b", "XY");

            string outputFilePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "OutPutDataFileTask7V16.txt"
            );

            File.WriteAllText(outputFilePath, result);
            return outputFilePath;
        }
    }
}