/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");

int number = Int32.Parse(Console.ReadLine() ?? "");

if ((number >=100) && (number < 1000))
{
    int num = number / 10 % 10;
    Console.WriteLine($"Вторая цифра введенного числа: {num}");
}
else {
    Console.WriteLine($"Число {number} не трехзначное");

}
