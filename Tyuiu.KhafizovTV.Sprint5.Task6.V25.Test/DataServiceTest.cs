using Tyuiu.KhafizovTV.Sprint5.Task6.V25.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            int result = ds.LoadFromDataFile(path);
            Assert.AreEqual(6, result);
        }
    }
}