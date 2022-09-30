// 37
Console.Clear();
int[] CreateArray()
{
    //Random rnd = new Random();  
    //int value = rnd.Next(10);  //Получить очередное случайное число

    int[] array = new int[new Random().Next(3, 8)]; //здесь регулируем количество элементов массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

int[] ProisvArray(int[] AnyArray)
{

    // куча переменных для помощи и ветвлений
    int lenarray = AnyArray.Length - 1;
    int ostatok = AnyArray.Length % 2;
    int lenNewArray = -1;
    int Polovinka = AnyArray.Length / 2;
    int lencikla = -1;

    // определяем длинну нового массива и длинну цикла заполнения исходя из четности длинны первого массива
    if (ostatok > 0)
    {
        lenNewArray = Polovinka + 1;
        lencikla = Polovinka;
    }
    else
    {
        lenNewArray = Polovinka;
        lencikla = Polovinka;
    }
    //объявляем новый массив
    int[] NewArray = new int[lenNewArray];

    //Если массив из нечетных элементов, то заполним сначало последний элемент нового массива
    if (ostatok > 0) NewArray[Polovinka] = AnyArray[Polovinka];

    //заполним элементы нового массива
    for (int i = 0; i < lencikla; i++)
    {
        NewArray[i] = AnyArray[i] * AnyArray[lenarray];
        lenarray--;
    }

    return NewArray;
}

int[] arr1 = CreateArray();
PrintArray(arr1);
Console.WriteLine();

int[] arr2 = ProisvArray(arr1);
PrintArray(arr2);


