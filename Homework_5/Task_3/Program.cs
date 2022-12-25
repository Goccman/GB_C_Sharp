/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/


//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 100);
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


// находит минимальный элемент массива
int MinElement(int[] array)
{
    int min = 0;
    array[0] = min;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }

    return min;
}


// находит максимальный элемент массива
int MaxElement(int[] array)
{
    int max = 0;
    array[0] = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}



Console.Write("Введите количество элементов в массиве: ");
int numArray = Int32.Parse(Console.ReadLine() ?? "");
int [] array = InitArray(numArray);
PrintArray(array);
int max = MaxElement(array);
int min = MinElement(array);
Console.WriteLine($"Максимальный элемент в массиве: {max}");
Console.WriteLine($"Минимальный элемент в массиве: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");
