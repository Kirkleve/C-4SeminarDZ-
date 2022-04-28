Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int[] array = new int[8];
FillArray(array);
Console.WriteLine($"Длинна массива {array.Length}");

string text = Convert.ToString(array);
for (int i = 0; i < array.Length; i++)
{
    
    text = text + array[i] + "," + " ";
}
Console.Write(text);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index< length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
} 
