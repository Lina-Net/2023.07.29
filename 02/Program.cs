// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

}


void MinSumRow(int [,] array)
{
    int [] sumRow = new int [array.GetLength(0)];
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        sumRow[i] = sum;
    }
    //for (int i = 0; i < array.GetLength(0); i++)
    //    Console.Write(sumRow[i] + " ");

    int minSumArr = sumRow[0];
    int numRow = 1;
    for (int f = 0; f < sumRow.Length; f++)
    {
        if (sumRow[f] < minSumArr)
        {
            minSumArr = sumRow[f];
            numRow = f + 1;
        }
    }
    Console.Write($"Строка с наименьшей суммой элементов: {numRow} строка");
}


Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
MinSumRow(matrix);