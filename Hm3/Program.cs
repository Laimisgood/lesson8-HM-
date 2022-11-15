// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

int rowA = Prompt("Введите количество строк для 1го массива: ");
int colA = Prompt("Введите количество столбцов для 1го массива: ");
int[,] matrA = CreateMatrix(rowA, colA);
PrintMatrix(matrA);
System.Console.WriteLine();
int rowB = Prompt("Введите количество строк для 2го массива: ");
int colB = Prompt("Введите количество столбцов для 2го массива: ");
int[,] matrB = CreateMatrix(rowB, colB);
PrintMatrix(matrB);
System.Console.WriteLine();
int[,] matrX = MatrixMultiplication(matrA, matrB);
PrintMatrix(matrX);