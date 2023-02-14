// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,,] GetArray(int m, int n, int w)
{
    int minValue = 10;
    int[,,] result = new int[m, n, w];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < w; k++)
            {
                result[i, j, k] = new Random().Next(minValue, minValue + 10);
                minValue += 10;
            }
        }
    }
    return result;
}

void PrintMatrix(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк матрицы");
    int col = Input("Введите кол-во столбцов матрицы");
    int width = Input("Введите ширину матрицы");
    int[,,] array = GetArray(row, col, width);
    PrintMatrix(array);
}

Main();
