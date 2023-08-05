// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        Console.Write("{0,3} ", matrix[i, j]);
        Console.WriteLine();
    }
}



void Main(string[] args)
{
    while (true)
    {
        Console.Write("Введите натуральное число: ");

        int n;
        if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

         Console.WriteLine();

        int[,] matrix = new int[n, n];

        int i = 0, j = 0;

        int v = 1;

        while (n != 0)
        {
            int k = 0;
            do { matrix[i, j++] = v++; } while (++k < n - 1);
            for (k = 0; k < n - 1; k++) matrix[i++, j] = v++;
            for (k = 0; k < n - 1; k++) matrix[i, j--] = v++;
            for (k = 0; k < n - 1; k++) matrix[i--, j] = v++;

            ++i; ++j; n = n < 2 ? 0 : n - 2;
        }

        PrintArray(matrix);
        Console.WriteLine();
    break;
    }
    
}

Main(args);