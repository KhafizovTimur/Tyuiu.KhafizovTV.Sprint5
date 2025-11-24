using Tyuiu.KhafizovTV.Sprint5.Task7.V16.Lib;

namespace Tyuiu.KhafizovTV.Sprint5.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string testContent = "Привет, как дела? Он написал письмо. Он ссорился с другом вчера.";
            string expected = "Привет, как дела? XY написал письмо. XY ссорился с другом вчера.";

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testContent);

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempPath);

            File.Delete(tempPath);

            Assert.AreEqual(expected, result);
        }
    }
}