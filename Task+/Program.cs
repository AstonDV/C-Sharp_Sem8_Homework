// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное 
// значение x и возвращает целую часть квадратного корня от введенного числа.

// 4 -> 2
// 28 -> 5
// Нельзя использовать встроенные функции библиотеки Math!


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int ManualExtractPow(int num)
{
    int tmp;
    int squareRoot = num / 2;
    do
    {
        tmp = squareRoot;
        squareRoot = (tmp + (num / tmp)) / 2;
    }
    while ((tmp - squareRoot) != 0);
    return squareRoot;
}

void PrintResult(int num, int pow)
{
    Console.WriteLine($"Целая часть квадратоного корня от {num} равна {pow}");
}

void Main()
{
    Console.Clear();
    int number = Input("Введите число, из которого вы хотите извлечь квадратный корень");
    int powOfNumber = ManualExtractPow(number);
    PrintResult(number, powOfNumber);
}

Main();