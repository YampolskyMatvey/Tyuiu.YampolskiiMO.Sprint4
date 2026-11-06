using Tyuiu.YampolskiiMO.Sprint4.Task5.V21.Lib;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #5 | Вариант #21                     *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Заполнить массив 5 на 5 случайными числами от -8 до 2 и заменить положительные элементы на 1.");
Console.WriteLine();

int[,] values = new int[5, 5];
for (int row = 0; row < values.GetLength(0); row++)
{
    for (int column = 0; column < values.GetLength(1); column++)
    {
        values[row, column] = Random.Shared.Next(-8, 3);
    }
}

Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
PrintMatrix(values);
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
PrintMatrix(new DataService().Calculate(values));

static void PrintMatrix(int[,] values)
{
    for (int row = 0; row < values.GetLength(0); row++)
    {
        for (int column = 0; column < values.GetLength(1); column++)
        {
            Console.Write($"{values[row, column],3}");
        }

        Console.WriteLine();
    }
}
