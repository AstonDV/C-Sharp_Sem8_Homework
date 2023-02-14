// // Задайте прямоугольный двумерный массив. Напишите программу, 
// // которая будет находить строку с наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int Input(string text)
// {
//     Console.Write($"{text}: ");
//     int value = int.Parse(Console.ReadLine()!);
//     return value;
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] SummValuesRowInArray(int[,] matrix)
// {
//     int[] array = new int[matrix.GetLength(0)];
//     int summ = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             summ += matrix[i, j];
//         }
//         array[i] += summ;
//         summ = 0;
//     }
//     return array;
// }

// int SearchMinSummInRows(int[] array)
// {
//     int minSumm = array[0];
//     int indexMinSumm = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < minSumm)
//         {
//             minSumm = array[i];
//             indexMinSumm = i;
//         }
//     }
    
//     return indexMinSumm;
// }

// void PrintResult(int indexMin)
// {
//     Console.WriteLine($"Номер строки заданного массива с наименьшей суммой элементов: {indexMin + 1}");
// }

// void Main()
// {
//     Console.Clear();
//     int row = Input("Введите кол-во строк");
//     int col = Input("Введите кол-во столбцов");
//     int minVal = Input("Введите минимальное значение");
//     int maxVal = Input("Введите максимальное значение");
//     Console.WriteLine();
//     int[,] array = GetArray(row, col, minVal, maxVal);
//     PrintArray(array);
//     int[] summInRows = SummValuesRowInArray(array);
//     int indexRowMinSum = SearchMinSummInRows(summInRows);
//     Console.WriteLine();
//     PrintResult(indexRowMinSum);
// }

// Main();

int PowManual(int n)
{
    int temp = 1;
    int x = 1;
    while (n / x == 0)
    {
        x = temp * temp;
        temp++;
    }

    return x;
}


void Main()
{
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine(PowManual(number));
}

Main();