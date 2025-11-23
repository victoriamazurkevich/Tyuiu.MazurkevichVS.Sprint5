using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MazurkevichVS.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string fullPath = Path.Combine(directory, fileName);

            double y = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return fullPath;
        }
    }
}
