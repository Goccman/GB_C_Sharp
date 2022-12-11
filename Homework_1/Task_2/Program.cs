/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число: ");
int numberThird = Int32.Parse(Console.ReadLine() ?? "");

int maxNumber = 0;

if (numberFirst > maxNumber) {
    maxNumber =numberFirst;
}

if (numberSecond> maxNumber) {
    maxNumber = numberSecond;
}
if (numberThird > maxNumber) {
    maxNumber = numberThird;
}

Console.WriteLine($"Максимальное число {maxNumber}");