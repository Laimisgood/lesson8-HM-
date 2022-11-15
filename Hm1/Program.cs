// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int ind = 0; ind < matrix.GetLength(1); ind++)
        {
            int min = matrix[i, ind];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    matrix[i, j] = matrix[i, ind];
                    matrix[i, ind] = min;
                }
            }
        }
    }
    return matrix;
}

int row = Prompt("Введите количество строк для массива: ");
int col = Prompt("Введите количество столбцов для массива: ");
int[,] matr = CreateMatrix(row, col);
PrintMatrix(matr);
System.Console.WriteLine();
PrintMatrix(SortMatrix(matr));