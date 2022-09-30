// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] CreateArray()
{

    double[] array = new double[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

int PosMax(double[] AnyArray)
{
    int PosMax = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] > AnyArray[PosMax]) PosMax = i;
    }
    return PosMax;
}

int PosMin(double[] AnyArray)
{
    int PosMin = 0;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        if (AnyArray[i] < AnyArray[PosMin]) PosMin = i;
    }
    return PosMin;
}

double[] arr1 = CreateArray();
PrintArray(arr1);
Console.WriteLine();

Console.WriteLine($" {arr1[PosMax(arr1)]} - {arr1[PosMin(arr1)]} = {arr1[PosMax(arr1)] - arr1[PosMin(arr1)]} ");


