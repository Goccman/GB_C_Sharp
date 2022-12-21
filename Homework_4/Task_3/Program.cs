/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


int []InitArray(int deminsion){
  int [] array = new int[deminsion];
  Random rnd = new Random();

  for (int i = 0; i < deminsion; i++)
  {
    array[i] = rnd.Next(0, 10);
  }
  return array;
}


void PrintArray(int [] array){
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
    
  }
  Console.Write("]");
  Console.WriteLine();

}


Console.Write("Элементы массива: ");
int [] arr = InitArray(8);
PrintArray(arr);
