/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.Write(message);

if(int.TryParse(Console.ReadLine(), out result))
isCorrect = true;
else
Console.WriteLine("Ввели не корректное число. \n1");
}

return result;
}


int ExofNumber(int a, int b){
    int result = 1;
     for (int i = 0; i < b; i++)
     {
        result = result * a;
     }

     return result;
}

int numOne = GetNumber("Введите первое число: ");
int numTwo = GetNumber("Введите второе число: ");
int res = ExofNumber(numOne, numTwo);
Console.WriteLine($"Число {numOne} в степени {numTwo} = {res}");

