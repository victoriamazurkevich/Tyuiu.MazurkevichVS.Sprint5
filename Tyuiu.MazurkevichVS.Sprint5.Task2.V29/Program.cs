
using Tyuiu.MazurkevichVS.Sprint5.Task2.V29.Lib;
DataService ds = new DataService();
int[,] matrix =
            {
                { 9, 2, 5 },
                { 3, 2, 4 },
                { 2, 8, 8 }
            };

int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл " + res);
Console.WriteLine("Создан!");
Console.ReadKey();