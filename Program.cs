/*В двумерном массиве целых чисел посчитать:
Сумму всех элементов массива
Среднее арифметическое всех элементов массива
Минимальный элемент
Максимальный элемент*/

using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static System.Console;

namespace HomeWork_11._04._20_task2
{
    class Program
    {
        static void InputArray(int[,] arr, int size)
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = random.Next(0, 10);
                }
            }
        }

        static void ShowArray(int[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Write($"{arr[i, j]}\t");
                }
                WriteLine("\n");
            }
        }

        static void SummAndAverage(int[,] arr, int size)
        {
            int summ = 0;
            double average;
            foreach (var item in arr)
            {
                summ += item;
            }

            average = summ / size;

            WriteLine($"Сумма элементов массива = {summ}");
            WriteLine($"Среднее арифметическое = {average}");
            WriteLine("\n");
        }

        static void MaximumMinimum(int[,] arr, int size)
        {
            int max = arr[0,0];
            foreach (var item in arr)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            WriteLine($"Максимальный элемент массива = {max}");

            int min = arr[0, 0];
            foreach (var item in arr)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            WriteLine($"Минимальный элемент массива = {min}");

        }

        static void Main(string[] args)
        {
            const int SIZE = 3;
            int[,] massive = new int[SIZE, SIZE];

            InputArray(massive, SIZE);
            ShowArray(massive, SIZE);
            SummAndAverage(massive, SIZE);
            MaximumMinimum(massive, SIZE);
        }
    }
}

