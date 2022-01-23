// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] EnterArray(int length, int first, int last)
{
    int [] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(first, last);
    }
    return array;
}
void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int [] array = EnterArray(10, 100, 1000);
PrintArray(array);
Console.WriteLine();

int count1 = 0;
int count2 = 0;
for(int j=0; j < array.Length; j++)
{ 
    if (array[j]%2==0)
        count1++;
    else
        count2++;
}
Console.WriteLine($"Количество четных чисел = {count1}; нечётных = {count2}");
