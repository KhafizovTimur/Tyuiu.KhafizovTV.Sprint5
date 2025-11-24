using Tyuiu.KhafizovTV.Sprint5.Task4.V6.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(9.427, result, 0.001);
        }
    }
}