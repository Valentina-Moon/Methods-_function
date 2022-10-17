// найти кол вхождений задонного числа в массив


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}");

    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}
int Count(int[] array, int valua)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]==valua)
            count++;
    return count;
}

Console.WriteLine("размер массива:");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];


FillArray(array, 0, 9);
Console.WriteLine();
Console.WriteLine("ваш массив");
Console.WriteLine();

PrintArray(array);

Console.WriteLine("Введите число:");
int valua = int.Parse(Console.ReadLine() ?? "0");
int count = Count(array, valua);

Console.WriteLine();
Console.WriteLine($"заданное число{valua} входит в массив{count} раз");
Console.WriteLine();

