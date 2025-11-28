using Tyuiu.MazurkevichVS.Sprint5.Task7.V20.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string directory = Path.Combine("C:", "DataSprint5");
string path = Path.Combine(directory, "InPutDataFileTask7V20.txt");
string temp = Path.GetTempPath(); string save = "OutPutDataFileTask7V20.txt";
string savepath = Path.Combine(temp, save);
Console.WriteLine("Данные находятся в: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Находятся в файле: " + savepath);
savepath = ds.LoadDataAndSave(path);
Console.WriteLine(savepath);
Console.ReadKey();