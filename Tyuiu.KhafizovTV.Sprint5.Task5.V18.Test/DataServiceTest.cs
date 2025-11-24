using Tyuiu.KhafizovTV.Sprint5.Task5.V18.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V18.txt";
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(542765.545, result, 0.001);
        }
    }
}