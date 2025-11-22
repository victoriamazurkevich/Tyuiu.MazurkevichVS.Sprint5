using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MazurkevichVS.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string fullPath = Path.Combine(directory, fileName);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;

                if (!double.IsFinite(y))
                {
                    y = 0;
                }

                y = Math.Round(y, 2);

                File.AppendAllText(fullPath, $"{y}\n");
                Console.WriteLine($"{x}\t{y}");
            }
            return fullPath;
        }
    }
}
