/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


//получить число с консоли
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}


//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


//распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


// вычисляет срееднее арефметическое столбцов матрицы
void AvgColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double avgCol = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            avgCol += matrix[j, i];
        }
        avgCol = Math.Round(avgCol / matrix.GetLength(0), 1);
        Console.WriteLine($"Среднеарефметическое столбца № {i + 1}: {avgCol}");
    }

}



int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = GetMatrix(m,n);

PrintMatrix(matrix);
Console.WriteLine();

AvgColumns(matrix);

