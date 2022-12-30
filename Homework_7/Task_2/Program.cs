/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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



// поиск позиции элемента в массиве
int FindElement(int number, int[,] matrix)
{
    int position = 0;
    int maxValue = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (position == number) return matrix[i, j];

            else if (position < number) position++;

            else if (position > number) break;
        }
    }
    Console.WriteLine($"В массиве элемент с позицией {number} не найден.");
    return maxValue;

}



int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = GetMatrix(m,n);

PrintMatrix(matrix);

int num = GetNumber("Введите искомую позицию элемента: ");

int element = FindElement(num, matrix);
Console.WriteLine($"В данном массиве элемент с позицией {num} равен {element}.");


