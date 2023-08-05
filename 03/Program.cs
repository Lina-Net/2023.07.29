// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}


int [,] MatrixMulti (int [,] matrix1, int [,] matrix2)
{
    int [,] finalMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            for (int q = 0; q < matrix2.GetLength(0); q++)
                finalMatrix[i,j] += matrix1[i,q]*matrix2[q,j];
        }
    }
    return finalMatrix;
}


Console.Write("Введите размеры первой матрицы через пробел: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размеры второй матрицы через пробел: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];

if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        InputArray(matrix1);
        InputArray(matrix2);
        PrintMatrix(MatrixMulti(matrix1, matrix2));
    }
else
    {
        Console.WriteLine("ОШИБКА!!! Произведение невозможно: количество столбцов первой матрицы не соответствует количеству строк второй матрицы");
    }