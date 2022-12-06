//Задайте двумерный массив размеров m*n, 
//заполненный случайными целыми числами

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);


// Метод создания двумерного массива
int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}



// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);


// Метод создания двумерного массива
int [,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
}



// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10);
int[,] Array2 = FillArray2(Array);
PrintArray(Array);
ChangeArray(Array2);
Console.WriteLine();
PrintArray(Array2);



// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}



// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray2(int[,] arrayX)
{
    int[,] NewArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i, j] = arrayX[i, j];
        }
    }
    return NewArray;
}

void ChangeArray(int[,] arrayZ)
{
    for (int i = 0; i < arrayZ.GetLength(0); i++)
    {
        for (int j = 0; j < arrayZ.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 ==0) arrayZ[i,j] = (int) Math.Pow(arrayZ[i,j], 2);
        }
    }
}
*/

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 10);
int[,] Array2 = FillArray2(Array);
PrintArray(Array);


// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}



// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray2(int[,] arrayX)
{
    int[,] NewArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i, j] = arrayX[i, j];
        }
    }
    return NewArray;
}

int SumOfDiagonalElements(int[,] arrayZ)
{
    int sum = 0;
    for (int i = 0; i < arrayZ.GetLength(0); i++)
    {
        for (int j = 0; j < arrayZ.GetLength(1); j++)
        {
            if(i == j) sum = sum + arrayZ[i,j];
        }
    }
    return sum;
}

Console.WriteLine($"Сумма диагональных элементов равна {SumOfDiagonalElements(Array)}");
*/

// Задать двумерный массив и сделать сортировку элементов по возрастанию в нечетных столбцах.


Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, 0, 9);
int[,] Array2 = FillArray2(Array);
PrintArray(Array);
Console.WriteLine();
SortArray(Array2);
PrintArray(Array2);

// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}



// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray2(int[,] arrayX)
{
    int[,] NewArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i, j] = arrayX[i, j];
        }
    }
    return NewArray;
}

int[,] SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j % 2 != 0)
        {

            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, j] < array[i, j + 1])   //ПЕРЕДЕЛАТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    {
                        temp = array[i, j + 1];
                        array[i, j + 1] = array[i, j];
                        array[i, j] = temp;
                    }
                }
            }

        }
    }
    return array;
}

// void GetSortColumnNec(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (j % 2 != 0)
//         {
//             bool flag = true;
//             while (flag)
//             {
//                 flag = false;
//                 for (int i = 0; i < array.GetLength(0) - 1; i++)
//                 {
//                     if (array[i, j] > array[i + 1, j])
//                     {
//                         int stakan = array[i, j];
//                         array[i, j] = array[i + 1, j];
//                         array[i + 1, j] = stakan;
//                         flag = true;
//                     }
//                 }
//             }
//         }
//     }
// }