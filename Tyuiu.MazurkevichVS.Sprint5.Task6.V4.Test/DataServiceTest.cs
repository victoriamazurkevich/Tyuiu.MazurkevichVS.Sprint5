using Tyuiu.MazurkevichVS.Sprint5.Task6.V4.Lib;
using System.IO;
namespace Tyuiu.MazurkevichVS.Sprint5.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod6()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);


            DataService ds = new DataService();
            double expected = 2;
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
