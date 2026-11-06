using Tyuiu.YampolskiiMO.Sprint4.Task1.V4.Lib;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #1 | Вариант #4                      *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти произведение нечётных элементов массива из 10 чисел.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("Введите 10 целых чисел от 1 до 9, по одному на строку.");

int[] values = new int[10];
for (int i = 0; i < values.Length;)
{
    string? input = Console.ReadLine();
    if (input is null)
    {
        Console.Error.WriteLine("Ввод завершился до заполнения массива.");
        return 1;
    }

    if (!int.TryParse(input, out int value) || value < 1 || value > 9)
    {
        Console.WriteLine("Введите целое число от 1 до 9.");
        continue;
    }

    values[i] = value;
    i++;
}

Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(values));
return 0;
