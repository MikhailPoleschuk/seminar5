// 32
Console.Clear();
int[] CreateArray()
{

    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
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


int[] InversArray(int[] AnyArray)
{
    int[] InversArray = new int[AnyArray.Length];
    for (int i = 0; i < AnyArray.Length; i++)
    {
        InversArray[i] = AnyArray[i]* (-1);
    }
    return InversArray;
}


int[] arr1 = CreateArray();
int[] arr2=InversArray(arr1);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);

