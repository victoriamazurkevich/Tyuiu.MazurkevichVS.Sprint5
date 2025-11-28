using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MazurkevichVS.Sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            int count = 0;
            foreach (char c in strx)
            {
                if ((c >= 'А') && (c <= 'Я'))
                {
                    if (char.IsUpper(c))
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
