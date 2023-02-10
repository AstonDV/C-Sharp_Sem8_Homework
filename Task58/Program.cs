// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:           Результирующая матрица будет:
// 2 4 | 3 4                           18 20
// 3 2 | 3 3                           15 18


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

int[,] MultiplicationMatrix(int[,] firstArray, int[,] secondArray)
{
    int firstMatrRow = firstArray.GetLength(0);
    int firstMatrCol = firstArray.GetLength(1);
    int secondMatrRow = secondArray.GetLength(0);
    int secondMatrCol = secondArray.GetLength(1);
    int[,] multiplicationArray = new int[firstMatrRow, secondMatrCol];
    for (int newRow = 0; newRow < firstMatrRow; newRow++)
    {
        for (int newCol = 0; newCol < secondMatrCol; newCol++)
        {
            for (int i = 0; i < firstMatrCol; i++)
            {
                multiplicationArray[newRow, newCol] += firstArray[newRow, i] * secondArray[i, newCol];
            }
        }
    }
    return multiplicationArray;
}

void Main()
{
    Console.Clear();
    int firstRow = Input("Введите кол-во строк первой матрицы");
    int firstCol = Input("Введите кол-во столбцов первой матрицы");
    int firstMinVal = Input("Введите минимальное значение первой матрицы");
    int firstMaxVal = Input("Введите максимальное значение первой матрицы");
    int secondRow = Input("Введите кол-во строк первой матрицы");
    int secondCol = Input("Введите кол-во столбцов первой матрицы");
    int secondMinVal = Input("Введите минимальное значение первой матрицы");
    int secondMaxVal = Input("Введите максимальное значение первой матрицы");
    Console.WriteLine();
    int[,] firstMatrix = GetArray(firstRow, firstCol, firstMinVal, firstMaxVal);
    int[,] secondMatrix = GetArray(secondRow, secondCol, secondMinVal, secondMaxVal);
    Console.WriteLine("Матрица А:");
    PrintArray(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("Матрица В:");
    PrintArray(secondMatrix);
    Console.WriteLine();
    if (firstCol != secondRow) Console.WriteLine("Заданные массивы нельзя перемножить!");
    else 
    {
        int[,] newMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
        Console.WriteLine("Произведение матриц А и В:");
        PrintArray(newMatrix);
    }
}

Main();