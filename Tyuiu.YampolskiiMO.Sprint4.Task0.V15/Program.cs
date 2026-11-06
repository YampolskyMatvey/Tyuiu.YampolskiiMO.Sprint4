using Tyuiu.YampolskiiMO.Sprint4.Task0.V15.Lib;

int[] values = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
var service = new DataService();

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #0 | Вариант #15                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти произведение нечётных элементов целочисленного массива.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(string.Join(", ", values));
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(service.Calculate(values));
