/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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


//получает сумму  элементов стоящих на нечетных позициях в массиве
int GetElementSumm(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ += arr[i];
    }
    return summ;
}


Console.Write("Введите количество элементов в массиве: ");
int numArray = Int32.Parse(Console.ReadLine() ?? "");
int[] array = InitArray(numArray);
PrintArray(array);
int sum = GetElementSumm(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в массиве: {sum}");
