/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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



// произведение двух матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


int m = GetNumber("Введите количество строк первой матрицы: ");
int n = GetNumber("Введите количество столбцов первой таблицы  и строк второй: ");
int p = GetNumber("Введите количество столбцов второй матрицы: ");
Console.WriteLine();
int[,] matrixOne = GetMatrix(m,n);
Console.WriteLine("Первая матрица");
PrintMatrix(matrixOne);
Console.WriteLine();
int[,] matrixTwo = GetMatrix(n,p);
Console.WriteLine("Вторая матрица");
PrintMatrix(matrixTwo);
Console.WriteLine();
int [,] resultMatrix = new int[m, p];
MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
Console.WriteLine("Произведение двух матриц");
PrintMatrix(resultMatrix);
