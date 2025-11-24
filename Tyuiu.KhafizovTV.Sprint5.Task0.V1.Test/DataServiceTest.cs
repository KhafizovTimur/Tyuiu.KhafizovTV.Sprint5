using Tyuiu.KhafizovTV.Sprint5.Task0.V1.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\pepe\source\repos\Tyuiu.KhafizovTV.Sprint5\Tyuiu.KhafizovTV.Sprint5.Task0.V1\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}