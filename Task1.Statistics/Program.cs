using System;

class Program
{
    static void Main()
    {
        // массив из 10 случайных чисел в диапазоне [1, 100]
        Random random = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // 101, т.к. верхняя граница не включается
        }

        //  выводим массив
        Console.WriteLine("Массив: " + string.Join(", ", numbers));

        // считаем сумму и произведение
        long sum = 0;
        double product = 1; // double, чтобы избежать переполнения
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];
        }
        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product.ToString("E2"));

        // считаем количество чётных
        int evenCount = 0;
        foreach (int n in numbers)
        {
            if (n % 2 == 0) evenCount++;
        }
        Console.WriteLine("Чётных чисел: " + evenCount);

        // среднее арифметическое и количество элементов, больших него
        double average = (double)sum / numbers.Length;
        int greaterThanAvg = 0;
        foreach (int n in numbers)
        {
            if (n > average) greaterThanAvg++;
        }
        Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAvg}");
    }
}
