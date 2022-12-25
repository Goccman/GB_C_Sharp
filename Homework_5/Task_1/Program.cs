/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}



//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//получает сумму четных элементов в массиве
int GetEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }

    return count;
}


Console.Write("Введите количество элементов в массиве: ");
int numArray = Int32.Parse(Console.ReadLine() ?? "");
int[] array = InitArray(numArray);
PrintArray(array);
int count = GetNumber(array);
Console.WriteLine($"Количество четных чисел в массиве: {count}");
