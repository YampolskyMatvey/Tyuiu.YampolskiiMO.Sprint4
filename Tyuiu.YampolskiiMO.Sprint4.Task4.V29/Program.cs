using Tyuiu.YampolskiiMO.Sprint4.Task4.V29.Lib;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #4 | Вариант #29                     *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти сумму чётных элементов массива 5 на 5.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("Введите 25 целых чисел от 4 до 8, по одному на строку.");

int[,] values = new int[5, 5];
for (int row = 0; row < values.GetLength(0); row++)
{
    for (int column = 0; column < values.GetLength(1);)
    {
        string? input = Console.ReadLine();
        if (input is null)
        {
            Console.Error.WriteLine("Ввод завершился до заполнения массива.");
            return 1;
        }

        if (!int.TryParse(input, out int value) || value < 4 || value > 8)
        {
            Console.WriteLine("Введите целое число от 4 до 8.");
            continue;
        }

        values[row, column] = value;
        column++;
    }
}

Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(values));
return 0;
