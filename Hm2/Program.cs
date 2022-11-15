// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int RowSum(int[,] matrix, int count)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = sum + matrix[count, i];
    }
    return sum;
}

int FindMinSum(int[,] matrix)
{
    int count = 0;
    int minSum = RowSum(matrix, count);
    int rowMS = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (RowSum(matrix, i) < minSum)
        {
            minSum = RowSum(matrix, i);
            rowMS = i;
        }
    }
    return rowMS;
}

int row = Prompt("Введите количество строк для массива: ");
int col = Prompt("Введите количество столбцов для массива: ");
int[,] matr = CreateMatrix(row, col);
PrintMatrix(matr);
int minRow = FindMinSum(matr);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с наим. суммой: {minRow}");