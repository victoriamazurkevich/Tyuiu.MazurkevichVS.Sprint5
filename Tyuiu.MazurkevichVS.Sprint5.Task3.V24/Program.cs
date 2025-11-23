using Tyuiu.MazurkevichVS.Sprint5.Task3.V24.Lib;

DataService ds = new DataService();
int x = 3;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл " + res);
Console.WriteLine("Создан!");
Console.ReadKey();