using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] numbers = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double product = 1;
            bool foundAny = false;

            foreach (string numStr in numbers)
            {
                if (double.TryParse(numStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    double absNumber = Math.Abs(number);
                    if (absNumber >= 10 && absNumber < 100)
                    {
                        product *= number;
                        foundAny = true;
                    }
                }
            }

            return foundAny ? Math.Round(product, 3) : 0;
        }
    }
}