// 31
Console.Clear();
int[] CreateArray()
{

    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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
int SumPol(int[] AnyArray)
{
    int sum = 0;

    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] > 0)
        {
            sum = sum + AnyArray[i];
        }
    }
    return sum;
}
int SumOtr(int[] AnyArray)
{
    int sum = 0;

    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] < 0)
        {
            sum = sum + AnyArray[i];
        }
    }
    return sum;
}

int[] arr1 = CreateArray();
PrintArray(arr1);
Console.WriteLine();
Console.WriteLine($"SumPol = {SumPol(arr1)}, SumOtr = {SumOtr(arr1)}");



