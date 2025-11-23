using System.IO;
using Tyuiu.MazurkevichVS.Sprint5.Task2.V29.Lib;
namespace Tyuiu.MazurkevichVS.Sprint5.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileMethod2()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { 9, 2, 5 },
                { 3, 2, 4 },
                { 2, 8, 8 }
            };
            string fullPath = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
