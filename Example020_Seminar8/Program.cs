
Console.WriteLine();
Console.WriteLine("Введите количество строк массива, затем количество столбцов массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
int columns2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] ArrayMain = CreateRandomArray(rows2, columns2);
PrintArray(ArrayMain);
Console.WriteLine();

// ==========================**Задача 53:** Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

/*
ChangeArray(ArrayMain);
PrintArray(ArrayMain);
*/

// ==========================**Задача 55:** Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести 
//сообщение для пользователя.

/*
ReplaceRowsWithColumns(ArrayMain);
Console.WriteLine();
PrintArray(ArrayMain);
*/

// ========================== **Задача** Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine(ArrayDell(ArrayMain));


//==============================Методы==============================

int[,] ReplaceRowsWithColumns(int[,] array)
{
    int temp = 0;
    if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Невозможно выполнить!");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    return array;
}

int[,] CreateRandomArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10, 100);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}

int[,] ChangeArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return array;
}

int[,] ArrayDell(int[,] array){
    int numbeMin = array[0,0];
    int num1=0 , num2 =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            if (numbeMin>array[i,j])
            { 
                numbeMin=array[i,j];
                num1=i ;
                num2 = j;
            }
        }
    }
    int [,] array2 = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i = 0 , x = 0 ; i < array.GetLength(0); x++, i++)
    {
        if ( i== num1) {
            x--;
            continue;
        }
        for (int j = 0 , y = 0; j < array.GetLength(1); y++, j++){
            if ( j== num2) {
            y--;
            continue;
            }
            array2[x,y]=array[i,j];
        }
    }
    return array2;
}
