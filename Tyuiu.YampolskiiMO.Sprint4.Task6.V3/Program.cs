using Tyuiu.YampolskiiMO.Sprint4.Task6.V3.Lib;

string[] values =
{
    "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
};

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #6 | Вариант #3                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Подсчитать количество строк длиной меньше шести символов.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(string.Join(", ", values));
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(values));
