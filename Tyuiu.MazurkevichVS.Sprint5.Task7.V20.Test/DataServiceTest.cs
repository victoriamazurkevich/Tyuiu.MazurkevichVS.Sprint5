using Tyuiu.MazurkevichVS.Sprint5.Task7.V20.Lib;
using System.IO;
namespace Tyuiu.MazurkevichVS.Sprint5.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod7()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);


            DataService ds = new DataService();
            string expected = "Словарные слова с удвоенной согласной нн";
            string actual = ds.LoadDataAndSave(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
