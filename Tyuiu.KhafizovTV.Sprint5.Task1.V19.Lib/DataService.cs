using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string filePath = Path.Combine(tempPath, fileName);
            string fileContent = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = 3 * x + 0.5;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = Math.Sin(x) + 2 / denominator + 2 * Math.Cos(x) * 2 * x;
                }

                fx = Math.Round(fx, 2);
                fileContent += fx.ToString(CultureInfo.InvariantCulture) + "\n";
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}