using Tyuiu.MazurkevichVS.Sprint5.Task0.V19.Lib;
int x = 3;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл" + res);
Console.WriteLine("Создан!");

Console.ReadKey();