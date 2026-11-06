using Tyuiu.YampolskiiMO.Sprint4.Task7.V4.Lib;

const string digits = "382976421897";

Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #4 | Задание #7 | Вариант #4                       *");
Console.WriteLine("************************************************************");
Console.WriteLine("УСЛОВИЕ:");
Console.WriteLine("Преобразовать строку в матрицу 3 на 4 и найти сумму нечётных чисел.");
Console.WriteLine();
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine(digits);
Console.WriteLine();
Console.WriteLine("РЕЗУЛЬТАТ:");
Console.WriteLine(new DataService().Calculate(3, 4, digits));
