Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int[] array = new int[8];
int index = 0;
FillArray(array);
Console.WriteLine($"Длинна массива {array.Length}");
while (index < array.Length)
{
    Console.Write(array[index]);
    index++;
}
  


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index< length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
} 
