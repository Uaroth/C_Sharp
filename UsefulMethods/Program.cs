// Collection of useful methods from lessons and practice solutions


// Перевести введённую текстом строку чисел через пробел в понятный
// консоли числовой массив

string userText = Console.ReadLine();
string[] userArray = userText.Split(" ");
double [] numbers = ReadNumbers (userArray);
double[] ReadNumbers(string[] text)
{
    double[] numbersArray = new double[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
        numbersArray[i] = double.Parse(text[i]);
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

int [] Revert(int [] arr)

{
    int [] revertArr = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        revertArr [i] = arr [arr.Length - 1 - i];
    }
    return revertArr;
}




// Получить случайную таблицу

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
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


