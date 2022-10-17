// 1 МЕТОД ЗАПОЛНЕНИЕ МАССИВА И ПЕЧАТИ НА ЭКРАН((лекция 2) )
//  СТРОКИ 1, 40 ПОТОМ 19 ПОТОМ 44 46 ПОТОМ 32 49 потом 65 67 68
// void- ничего не возврашает.
void FillArray(int[] collection) // наиммонование
{
    int lenght = collection.Length;
    // длинна массива
    int i = 0;

    while (i < lenght)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }

}


void PrintArray(int[] col)  // печатать массив

{
    int count = col.Length; //количество элементов
    int position = 0;
    // позиция(тот же индекс) 
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// МЕТОД НАХОЖДЕНИЯ ПОЗИЦИИ НУЖНОГО ЭЛЕМЕНТА.

int IndexOf(int[] collection, int find) //IndexOf ниминование. int[] collection - массив. int find - найти какой-то элемент
{
    int count = collection.Length;// кол. элементов
    int i = 0;// переберать массив
    int position = -1;
    while (i < count)
    {
        if (collection[i] == find)
        {                               // надо куда-то сохранить
            position = i; // положим значение индекса
            break;
        }

        i++;
    }

    return position;//Оператор return завершает выполнение функции и возвращает управление вызывающей функции. 
                    //Выполнение возобновляется в вызывающей функции в точке сразу после вызова. 
                    //Оператор return может возвращать значение, передавая его вызывающей функции. 
}
int[] arr = new int[10]; //создай новы массив 10 элементов. по умалчанию заполненн нулями.


FillArray(arr); // тестим/ наиминоваание

PrintArray(arr);
Console.WriteLine(); // для того чтобы выевить не являеться частью массива

int pos = IndexOf(arr, 444);
Console.WriteLine(pos);