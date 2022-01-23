//  Определить, присутствует ли в заданном массиве, некоторое число

int [] EnterArray(int length, int first, int second)
{
    int [] array = new int[length];
    for (int i = 0; i< length; i++)
    {
        array[i]= new Random().Next(first, second);
    }
    return array;
}

void PrintArray(int [] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int [] array = EnterArray(10, 0, 10);

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

PrintArray(array);
Console.WriteLine();

bool Contain (int[] array)
{
    for(int j=0; j < array.Length; j++)
    {
        if (array[j] == number)
            return true;
    }
    return false;

}

if(Contain(array) == true)
    Console.WriteLine($"Заданное число {number} присутствует в массиве");
else 
    Console.WriteLine($"Заданного числа {number} нет в массиве");