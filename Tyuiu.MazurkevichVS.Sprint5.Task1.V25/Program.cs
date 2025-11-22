using Tyuiu.MazurkevichVS.Sprint5.Task1.V25.Lib;

DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("startValue " + startValue);
Console.WriteLine("stopValue " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл " + res);
Console.WriteLine("Создан!");
Console.ReadKey();