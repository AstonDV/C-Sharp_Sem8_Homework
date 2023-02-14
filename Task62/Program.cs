// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

string[] ArrayOfValues(int size)
{
    string[] array = new string[size];
    int count = 01;
    for (int i = 0; i < size; i++)
    {
        array[i] = count.ToString("00");
        count++;
    }
    return array;
}

string[,] GetArray(int m, int n)
{
    string[,] result = new string[m, n];
    string[] array = ArrayOfValues(result.Length);
    int arrayCount = 0;
    int quantityOfValues = result.Length;
    int quantityOfRows = result.GetLength(0);
    int quantityOfColumns = result.GetLength(1);
    
    for (int i = 0; i < quantityOfValues; i++)
    {
        if (arrayCount < array.Length)
        {
            for (int rowStepRight = 0 + i; rowStepRight < quantityOfColumns - i; rowStepRight++)
            {
                int positionForStepRight = 0 + i;
                result[positionForStepRight, rowStepRight] = array[arrayCount];
                arrayCount++;
            }
        }

        if (arrayCount < array.Length)
        {
            for (int columnStepDown = 1 + i; columnStepDown < quantityOfRows - i; columnStepDown++)
            {
                int positionForStepDown = quantityOfColumns - 1 - i;
                result[columnStepDown, positionForStepDown] = array[arrayCount];
                arrayCount++;
            }
        }

        if (arrayCount < array.Length)
        {
            for (int rowStepLeft = quantityOfColumns - 2 - i; 0 + i <= rowStepLeft; rowStepLeft--)
            {
                int positionStepLeft = quantityOfRows - 1 - i;
                result[positionStepLeft, rowStepLeft] = array[arrayCount];
                arrayCount++;
            }
        }

        if (arrayCount < array.Length)
        {
            for (int columnStepUp = quantityOfRows - 2 - i; 0 + i < columnStepUp; columnStepUp--)
            {
                int positionForStepUp = 0 + i;
                result[columnStepUp, positionForStepUp] = array[arrayCount];
                arrayCount++;
            }
        }
    }
    return result;
}

void PrintArray(string[,] inArray)
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

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк матрицы");
    int col = Input("Введите кол-во столбцов матрицы");
    Console.WriteLine();
    string[,] matrix = GetArray(row, col);
    PrintArray(matrix);  
}

Main();