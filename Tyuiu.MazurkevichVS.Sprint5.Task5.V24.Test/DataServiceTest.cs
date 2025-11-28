using Tyuiu.MazurkevichVS.Sprint5.Task5.V24.Lib;
using System.IO;
namespace Tyuiu.MazurkevichVS.Sprint5.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod5()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);


            DataService ds = new DataService();
            double expected = 63;
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
