//двумерные массивы

void PrintArray (int[,] matr) //создаем двумерный массив
{
for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) это длина строки
{
    for (int j =0; j < matr.GetLength(1); j++) //GetLength(1) это длина столбца
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void FillArray (int[,] matr) // заполняем рандомными числами двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) это длина строки
{
    for (int j =0; j < matr.GetLength(1); j++) //GetLength(1) это длина столбца
    {
        matr[i,j] = new Random().Next(1,10);
    }

}   
}

int [,] matrix = new int [3,4]; // 1-я цифра количество строкб 2-я столбцов (от 0)
PrintArray (matrix);

FillArray (matrix);
PrintArray (matrix);
