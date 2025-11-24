using Tyuiu.KhafizovTV.Sprint5.Task1.V19.Lib;
using System.Globalization;

namespace Tyuiu.KhafizovTV.Sprint5.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(11, lines.Length);

            double firstValue = double.Parse(lines[0], CultureInfo.InvariantCulture);
            Assert.AreEqual(-4.85, firstValue, 0.01);
        }
    }
}