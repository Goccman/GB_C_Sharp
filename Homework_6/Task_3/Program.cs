/*Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.

*/


// проверка и вывод чисел, введеных пользователем
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Ввели не корректное число. \n1");
    }

    return result;
}

//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(10, 100);
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

// создает поэлементную копию массива
void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}



int numArray = GetNumber("Введите количество элементов в массиве: ");
Console.Write("Элементы массива: ");
int[] arr = InitArray(numArray);
PrintArray(arr);
Console.WriteLine();
Console.Write("Копия массива:    ");
int[] copyArr = new int[numArray];
CopyArray(arr, copyArr);
PrintArray(copyArr);

