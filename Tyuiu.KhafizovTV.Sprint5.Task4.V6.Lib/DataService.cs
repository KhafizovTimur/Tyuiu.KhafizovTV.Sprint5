using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            content = content.Trim();
            double x = double.Parse(content, CultureInfo.InvariantCulture);
            double y = Math.Round((1 /Math.Cos(x)) + 2.2 * (x*x), 3);
            return y;
        }
    }
}