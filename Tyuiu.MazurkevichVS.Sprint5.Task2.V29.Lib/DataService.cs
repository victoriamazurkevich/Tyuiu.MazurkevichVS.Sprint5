using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MazurkevichVS.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string fullPath = Path.Combine(directory, fileName);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) { str += matrix[i, j] + ";"; }
                    else { str += matrix[i, j]; }
                }

                if (i != rows - 1) { File.AppendAllText(fullPath, str + Environment.NewLine); }
                else { File.AppendAllText(fullPath, str); }
                str = "";
            }
            return fullPath;
        }
    }
}
