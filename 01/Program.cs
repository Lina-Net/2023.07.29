// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


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

void PrintArray (int [,] array)
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

void SortArray(int [,] matrix)
{     
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k <  matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i,k] < matrix[i,k+1])
                {
                    temp = matrix[i,k+1];
                    matrix[i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
                
            }     
            
        }
      
    }
  
}


Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
SortArray(matrix);
PrintArray(matrix);


