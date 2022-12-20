/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
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


int SumNumber(int num){
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
}

int number = GetNumber("Введите число: ");
int summ = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} = {summ}");


