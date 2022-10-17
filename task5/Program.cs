// упарядочить массив
//алгоритом сортировки метода( агоритом сортировки мин мак)

// 6 8 3 2 1 4 5 7 - выбрать элемент(6) в оставщейся части с учетом нашей позиции(6) найти мин(1) и поменять их местами.
//и так далее с другими элементами

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// вывести масив на экран

void PrintArray(int[] array)
{

    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }

    Console.WriteLine();
}

// упорядочивание массива

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)


    {
        int minPosition = i;  // позиция запоминаем будем производить действия.
        for (int j = i + 1; j < array.Length; j++) // поиск мин позиции
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i]; // меняем местами
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);