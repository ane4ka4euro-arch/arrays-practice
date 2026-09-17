using System;

int n = 0;

while (n <= 0)
{
    Console.Write("Введите количество элементов: ");

    try
    {
        n = int.Parse(Console.ReadLine() ?? "");

        if (n <= 0)
        {
            Console.WriteLine("Количество должно быть больше 0.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка ввода.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка ввода.");
    }
}

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    try
    {
        Console.Write("Элемент [" + i + "]: ");
        numbers[i] = int.Parse(Console.ReadLine() ?? "");
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка ввода.");
        i--;
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка ввода.");
        i--;
    }
}

Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

Console.Write("Обратный порядок: ");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i]);

    if (i > 0)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();

Array.Sort(numbers);

Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));

int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine("Минимум: " + min);
Console.WriteLine("Максимум: " + max);
