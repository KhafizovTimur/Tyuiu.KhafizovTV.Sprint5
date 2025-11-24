using Tyuiu.KhafizovTV.Sprint5.Task2.V29.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] array = {
                {9, 2, 5},
                {3, 2, 4},
                {2, 8, 8}
            };

            string filePath = ds.SaveToFileTextData(array);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string expected = "0;2;0\n0;2;4\n2;8;8";

            Assert.AreEqual(expected, content);
        }
    }
}