using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string filePath = Path.Combine(tempPath, fileName);

            double y = Math.Round(Math.Pow(x, 3) / Math.Pow(2 * (x + 5),2), 3);

            byte[] binData = BitConverter.GetBytes(y);

            File.WriteAllBytes(filePath, binData);

            return filePath;
        }
    }
}