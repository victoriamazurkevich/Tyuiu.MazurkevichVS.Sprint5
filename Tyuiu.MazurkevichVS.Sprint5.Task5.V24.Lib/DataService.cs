using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.MazurkevichVS.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');

                    foreach (string number in lineArray)
                    {
                        double lineParse = double.Parse(number);

                        if (lineParse % 1 == 0 && lineParse >= 10)
                        {
                            res += lineParse;
                        }

                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
