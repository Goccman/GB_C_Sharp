/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите  число: ");
int number = Int32.Parse(Console.ReadLine() ?? "");

if (number == 6 || number == 7) {
  Console.WriteLine("Выходной!");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine($"{number} - это не день недели. Введите цифру от 1 до 7.");
  }
  else Console.WriteLine("Этот день не выходной.");

