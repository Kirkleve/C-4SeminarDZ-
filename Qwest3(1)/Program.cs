//Это третья задача которую так и не решил, суть такова, пытался сделать так 
//чтобы пользователь вводил любые числа, потом это всё переводилось строкой через запятую, ну а потом в массив!
// вывести в массив так и не получилось( как только не пробовал.



Console.WriteLine("Введите значения индексов массива из 8 элементов ");
int[] array = new int[8];
string text = String.Empty;

for (int i = 0; i < array.Length; i++)
{
    
    array[i] = Convert.ToInt32(Console.ReadLine());
    text = text + array[i] + ","+" ";
}

Console.WriteLine(text);

for (int i = 0; i < array.Length; i++)
{
    string[] arrayNumbers = text.Split(new char[] {','});
    text = text + array[i];
}

Console.WriteLine($"Длинна массива из 8 чисел = " + text);

/*char [] massive = new char [text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        array[i] = text[i];
    }
Console.WriteLine($"{text}");*/


/*Console.WriteLine("Введите 8 чисел");
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
} */
