// 35
Console.Clear();

int[] CreateArray()
{

    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

int Count(int[] AnyArray)
{
    int count = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] > 9 & AnyArray[i] < 100)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] arr1 = CreateArray();
PrintArray(arr1);
Console.WriteLine();
int count = Count(arr1);
Console.WriteLine(count);


