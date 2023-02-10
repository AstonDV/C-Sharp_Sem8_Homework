// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:                 В итоге получается вот такой массив:
// 1 4 7 2                                 7 4 2 1
// 5 9 2 3                                 9 5 3 2
// 8 4 2 4                                 8 4 4 2


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void Sorting2DArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
        BubbleSort(array);
        count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = array[count++];
        }
        count = 0;
    }
}

void BubbleSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    int minVal = Input("Введите минимальное значение");
    int maxVal = Input("Введите максимальное значение");
    Console.WriteLine();
    int[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
    Sorting2DArray(array);
    Console.WriteLine();
    PrintArray(array);
}

Main();