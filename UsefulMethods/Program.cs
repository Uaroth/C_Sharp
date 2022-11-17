﻿// Collection of useful methods from lessons and practice solutions


// Запросить и запарсить число

int SetNumber(string numberName)
{
    Console.WriteLine($"Enter number {numberName}");
    int num = int.Parse(Console.ReadLine());
    return num;
}


// Перевести введённую текстом строку чисел через пробел в понятный
// консоли числовой массив


int[] GetArrayFromString(string text)
{
    string[] numbers = text.Split(" ");
    int[] numbersArray = new int[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
        numbersArray[i] = int.Parse(numbers[i]);
    }
    return numbersArray;
}



// Заполнить массив случайными числами в диапазоне

int[] RandomFill(int[] numbers)
{
    Console.WriteLine("Массив таков");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 51);
        Console.Write($"{numbers[i]} . ");
    }
    Console.WriteLine();
    return numbers;
}



// Вычленять и суммировать цифры в числе
// через отсечение лишних разрядов делением на 10 и модуль

void SumAll(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {sum}");
}



// Развернуть массив

int[] Revert(int[] arr)

{
    int[] revertArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        revertArr[i] = arr[arr.Length - 1 - i];
    }
    return revertArr;
}




// Получить случайную таблицу

int[,] GetRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


// Заполнить таблицу случайными числами от 1 до 10

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


// Вывести таблицу

void PrintMatrix(int[,] matr)
{
    Console.WriteLine("Матрица целочисленных готова");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
}


// Найти индекс элемента

void CheckIndMatr(int[,] matr)
{
    Console.WriteLine("Укажите значение для получения индекса");
    int num = int.Parse(Console.ReadLine());
    int numCount = 0; // Чтоб остановить после первого обнаружения и зафиксировать отсутствие
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (numCount == 0 && num == matr[i, j])
            {
                numCount++;
                Console.WriteLine($"Индекс = ({i},{j})");

            }
        }
    }
    if (numCount == 0) Console.WriteLine("Нет такого значения");
}



// Найти среднее арифметическое каждого столбца

void FindMatrAvrg(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} = {sum / matr.GetLength(0)}");
    }
}



// Сортировка матрицы (строки по убыванию)

int[,] SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }

        }
    }
    return matr;
}