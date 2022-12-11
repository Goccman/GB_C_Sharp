/*
Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 - max = 7
a = 2 b = 10 - max = 10
a = -9 b = -3 - max = -3
*/

Console.Write("Введите первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine() ?? "");
if (numberFirst > numberSecond)
    {  
    Console.WriteLine($"Большее число {numberFirst}, меньшее число {numberSecond}");
}
    else {
    Console.WriteLine($"Большее число {numberSecond}, меньшее число {numberFirst}");    
}

