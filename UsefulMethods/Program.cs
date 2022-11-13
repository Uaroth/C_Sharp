// Collection of useful methods from lessons and practice solutions


// Запросить и запарсить число

int SetNumber(string text)
{
    string[] arr = text.Split(" ");
    Console.WriteLine($"Enter number {text}");
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

int[,] GetRandomMatrix(int rows, int columns, int maxValue, int minValue)
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

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


