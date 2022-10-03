void FillArray(int[] collection) // функция создает рандомные массивы 
{    
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // значения массива будут от 1 до 9
        index++;
    }
}

void PrintArray(int[] col) // функция печатает массив 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // функция поиска индекса в котором лежит значение find
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 по умолчанию, чтобы если нет подходящего значения вывело это значение
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // если его не поставить, то выведет все позиции массива удовлетворяющие условию
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int[10] - длина масива

 FillArray(array);
 PrintArray(array);

Console.WriteLine(); 

int pos = IndexOf(array, 5); // ищем в какой первой ячейке массива находится значение 5
Console.WriteLine(pos);
