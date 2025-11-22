using Tyuiu.MazurkevichVS.Sprint5.Task0.V19.Lib;
using System.IO;
namespace Tyuiu.MazurkevichVS.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileMethod0()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
