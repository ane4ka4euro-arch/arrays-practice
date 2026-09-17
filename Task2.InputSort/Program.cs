using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            bool ok = false;
            while (!ok)
            {
                Console.Write("Введите кол-во элементов: ");
                try
                {
                    N = int.Parse(Console.ReadLine() ?? "");
                    if (N > 0)
                        ok = true;
                    else
                        Console.WriteLine("Ошибка: N должно быть больше 0!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число слишком большое!");
                }
            }

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                bool okElem = false;
                while (!okElem)
                {
                    Console.Write("Элемент [" + i + "]: ");
                    try
                    {
                        arr[i] = int.Parse(Console.ReadLine() ?? "");
                        okElem = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введено не число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое!");
                    }
                }
            }

            Console.WriteLine();

            Console.Write("Исходный массив:  ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i]);
                if (i < N - 1) Console.Write(", ");
            }
            Console.WriteLine();

            Console.Write("Обратный порядок: ");
            for (int i = N - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i > 0) Console.Write(", ");
            }
            Console.WriteLine();

            Array.Sort(arr);
            Console.Write("Отсортированный:  ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i]);
                if (i < N - 1) Console.Write(", ");
            }
            Console.WriteLine();

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < N; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Минимум: " + min);

            Console.ReadKey();
        }
    }
}