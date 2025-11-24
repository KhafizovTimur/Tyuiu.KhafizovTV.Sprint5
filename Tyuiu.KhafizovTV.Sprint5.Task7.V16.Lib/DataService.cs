using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {

            string content = File.ReadAllText(path);

            string pattern = @"\b\w{2}\b";

            string result = Regex.Replace(content, pattern, "XY");

            string outputPath = Path.GetTempFileName();

            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}