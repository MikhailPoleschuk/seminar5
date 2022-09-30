// 33
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
Console.WriteLine();

}
int PoiskChisla(int[] AnyArray, int chislo)
{
    int da = 0;

    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] == chislo)
        {
            da = 1;
            return da;
        }
    }
    return da;
}


int[] arr1 = CreateArray();
PrintArray(arr1);

Console.WriteLine("Введите X:");
int x = Convert.ToInt32(Console.ReadLine());

int da = PoiskChisla(arr1, x);
if (da == 1) Console.WriteLine("ДА");
if (da == 0) Console.WriteLine("нет");
