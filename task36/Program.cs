// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] CreateArray()
{
//Random rnd = new Random();  
//int value = rnd.Next();  //Получить очередное случайное число

    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
int Sum(int[] AnyArray)
{
    int sum = 0;
    int ostatokdelenya = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        ostatokdelenya = AnyArray[i] % 2;
        if (ostatokdelenya != 0)
        {
            sum = sum + AnyArray[i];
        }
    }
    return sum;
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
int sum=Sum(arr1);
Console.WriteLine();
Console.WriteLine(sum);