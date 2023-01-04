/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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


// Распечатать матрицу.
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


// находит сумму элементов в каждой строке массива
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    Console.WriteLine($"В строке {i + 1} сумма элементов равна: {sumLine}");
    return sumLine;

}


// выводит строку массива с наименьшей суммой элементов
void RowMinSum(int[,] array)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine($"В строке {minSumLine +1} наименьшая сумма элементов.");
}
   

int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = GetMatrix(m,n);

PrintMatrix(matrix);
Console.WriteLine();
RowMinSum(matrix);