using System.IO;
using Tyuiu.MazurkevichVS.Sprint5.Task3.V24.Lib;
namespace Tyuiu.MazurkevichVS.Sprint5.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod3()
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
