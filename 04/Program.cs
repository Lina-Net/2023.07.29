// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void InputArray(int[, ,] matrix)
{
    int tempSize = matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);
    int [] tempArr = UniqueCheck(tempSize);
    int iTemp = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (iTemp >= 0 && iTemp < tempSize)
                {
                    matrix[i, j, k] = tempArr[iTemp];
                    iTemp++;
                    Console.Write($"{matrix[i, j, k]} ({i};{j};{k}) \t");
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [] UniqueCheck (int size)
{
    int [] uniqueArr = new int [size];
    for (int i = 0; i < size; i++)
    {
        uniqueArr[i] = new Random().Next(10, 100);
        if (i != 0)
        {
            for (int y = 0; y < i; y++)
            {
                while (uniqueArr[y] == uniqueArr[i])
                {
                    uniqueArr[y] = new Random().Next(10, 100);
                }
            }
        }
    }
    return uniqueArr;
}

Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ,] matrix = new int[size[0], size[1], size[2]];
if (matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2) <= 90)
{
    InputArray(matrix);
}
else 
{
    Console.WriteLine("ОШИБКА!!! Невозможно заполнить массив неповторяющимися двухзначными числами!");
}