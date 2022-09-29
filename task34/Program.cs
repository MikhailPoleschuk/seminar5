// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
int[] CreateArray()
{

    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

int CountChet(int[] AnyArray)
{
    int count = 0;
    int ostatokdelenya = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        ostatokdelenya = AnyArray[i] % 2;
        if (ostatokdelenya == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

int[] arr1 = CreateArray();
PrintArray(arr1);
int count = CountChet(arr1);
Console.WriteLine();
Console.WriteLine(count);





