// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine($"\nВведите размер массива m x n:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int minSum = 0;
int sum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSum = Sum(array, i);
    if (sum > tempSum)
    {
        sum = tempSum;
        minSum = i;
    }
}

Console.WriteLine($"\n{minSum + 1} строка - строкa с наименьшей суммой элементов: сумма ({sum})");

int Sum(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
