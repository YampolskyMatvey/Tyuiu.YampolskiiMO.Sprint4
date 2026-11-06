using Tyuiu.YampolskiiMO.Sprint4.Task2.V13.Lib;

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #2 | Вариант #13                     *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Найти произведение чётных элементов массива из 13 случайных чисел от 2 до 9.");
Console.WriteLine();

int[] values = new int[13];
for (int i = 0; i < values.Length; i++)
{
    values[i] = Random.Shared.Next(2, 10);
}

Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(string.Join(", ", values));
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(values));
