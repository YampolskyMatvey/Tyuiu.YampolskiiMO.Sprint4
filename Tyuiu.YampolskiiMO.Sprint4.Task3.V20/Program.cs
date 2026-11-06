using Tyuiu.YampolskiiMO.Sprint4.Task3.V20.Lib;

int[,] values =
{
    { 8, 7, 7, 8, 5 },
    { 4, 3, 5, 3, 6 },
    { 5, 3, 8, 6, 3 },
    { 6, 3, 8, 5, 4 },
    { 3, 6, 8, 3, 4 }
};

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #3 | Вариант #20                     *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти минимальный элемент в первом столбце массива 5 на 5.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
for (int row = 0; row < values.GetLength(0); row++)
{
    for (int column = 0; column < values.GetLength(1); column++)
    {
        Console.Write($"{values[row, column],3}");
    }

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(values));
