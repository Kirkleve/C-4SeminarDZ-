/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Поправка: на семинаре дал добро на заполнение массива рандомными числами. 
В оригинале нужно пользователю ввести строку - ряд чисел через запятую,
а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)*/

/*Console.WriteLine("Введите длину массива из 8 элементов ");
int[] array = new int[8];
string text = String.Empty;

for (int i = 0; i < array.Length; i++)
{
    
    array[i] = Convert.ToInt32(Console.ReadLine());
    text = text + array[i] + ",";
}

Console.WriteLine(text);
for (int i = 0; i < array.Length; i++)
{
    string[] _arrayNumbers = text.Split(new char[] {','});
    text = text + array[i];
}
Console.WriteLine(text);*/



/*char [] massive = new char [text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        array[i] = text[i];
    }
Console.WriteLine($"{text}");
Console.WriteLine();*/

Console.Write("Введите числа через запятую: ");
string[] array = new string[8];
string numbers = String.Empty;

IntString(numbers);

void IntString (string num)
{
    for(int i = 0; i < array.Length; i++)
    {
        string array = Console.ReadLine();
        numbers = numbers + array[i] + ",";
        Console.Write(numbers);
    }
}
Console.Write(numbers);
void Simbol(string str)
{
    for (int i = 0; i < array.Length; i++)
    {
        
    }
}


/*numbers = numbers.Replace(" ", "");
string[] _arrayNumbers = numbers.Split(new char[] {','});

for(int i = 0; i < _arrayNumbers.Length; i++)
{
    Console.Write($"{_arrayNumbers[i]} ");
}*/
