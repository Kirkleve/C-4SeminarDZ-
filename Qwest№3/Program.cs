/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Поправка: на семинаре дал добро на заполнение массива рандомными числами. 
В оригинале нужно пользователю ввести строку - ряд чисел через запятую,
а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)*/

Console.WriteLine("Введите 8 чисел через запятую");
string? number = Console.ReadLine();
string newNumber = Replace(number, ',', ' ');
char[] array;
array = newNumber.ToCharArray();
WriteArray(array);

void WriteArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

string Replace(string number, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = number.Length;
    for (int i = 0; i < length; i++)
    {
        if(number[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else result = result + $"{number[i]}";
    }
    return result;
}

