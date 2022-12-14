/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


//  получить число с консоли
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



//  находит сумму элементов в промежутке между числами с помощью рекурсии
int SumNumber(int m, int n)
{
    int result = 0;
    if (m > n)
    {
        Console.WriteLine("Ввели второе число меньше первого");
    }
    else
    {
        result = SumNumber(m + 1, n) + m;
    }
    return result;
}



int m = GetNumber("Введите первое число: ");
int n = GetNumber("Введите число больше первого: ");
int result = SumNumber(m, n);
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} равняется {result}");

