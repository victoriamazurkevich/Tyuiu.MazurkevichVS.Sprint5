using System.IO;
using Tyuiu.MazurkevichVS.Sprint5.Task1.V25.Lib;
namespace Tyuiu.MazurkevichVS.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileMethod1()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
