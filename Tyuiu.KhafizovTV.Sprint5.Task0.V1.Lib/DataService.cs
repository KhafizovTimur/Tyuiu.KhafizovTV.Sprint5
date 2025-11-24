using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double exp = (Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + (5 * x) + 4);
            exp = Math.Round(exp, 3);
            string res = exp.ToString(CultureInfo.GetCultureInfo("ru-RU"));
            File.WriteAllText(path, res);
            return path;
        }
    }
}