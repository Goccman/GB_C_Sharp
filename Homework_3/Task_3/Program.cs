/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.Write("Введите  число: ");
int number = Int32.Parse(Console.ReadLine() ?? "");

void Cube(int[] number){
  int counter = 0;
  int length = number.Length;
  while (counter <  length){
    number[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] arr){
  int count = arr.Length;
  int index = 1;
  while(index < count){
    Console.Write(arr[index]+ " ");
    index++;
  }
  Console.WriteLine();
} 

int[] array = new int[number+1];
Cube(array);
PrintArray(array);



