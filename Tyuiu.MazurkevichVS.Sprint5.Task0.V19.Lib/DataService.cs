using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MazurkevichVS.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string directory = Path.GetTempPath(); 
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(directory, fileName);

            double y = (2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2));
            y = Math.Round(y, 3);
            File.WriteAllText(fullPath, Convert.ToString(y));

            return fullPath;
        }
    }
}
