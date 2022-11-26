// Задайте массив из 12-ти элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива

/*
int[] ArrayMain = Array(12, -9, 9);
Console.WriteLine($"Массив: [{String.Join(", ", ArrayMain)}]");

int positiveSum = 0;
int negativeSum = 0;
foreach (int element in ArrayMain)
{
    if (element < 0)
    {
        negativeSum += element;
    }
    else
    {
        positiveSum += element;
    }
}

Console.WriteLine($"Сумма положительных чисел данного массива равна {positiveSum}, отрицательных - {negativeSum}");

int[] Array(int number, int minValue, int maxValue)
{
    int[] arrayN = new int[number];
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(minValue, maxValue + 1); //+ 1 чтобы включить в массив девятку
    }
    return arrayN;
}
*/

// Напишите программу, которая будет менять элементы в массиве: положительные на соответствующие отрицательные, и наоборот

/*
Console.Write("Введите размер массива: ");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите отрицательное число (начало диапазона массива): ");
int MinValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число (конец диапазона массива): ");
int MaxValue = int.Parse(Console.ReadLine()!);

int[] ArrayMain = Array(Size, MinValue, MaxValue);
int[] ArrayMain2 = Array2(ArrayMain);
Console.WriteLine($"Массив: [{String.Join(", ", ArrayMain)}]");
Console.WriteLine($"Массив с изменёнными элементами: [{String.Join(", ",ArrayMain2)}]");

int[] Array(int number, int minValue, int maxValue)
{
    int[] arrayN = new int[number];
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(minValue, maxValue + 1); //+ 1 чтобы включить в массив девятку
    }
    return arrayN;
}

   int[] Array2(int [] array)
{
    int[] array2N = new int [array.Length];
    for (int i=0; i<array.Length; i++)
    {
        array2N[i] = -array[i];
    }
    return array2N;
}
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

/*
int[] ArrayMain = Array(12, -9, 9);
Console.WriteLine($"Массив: [{String.Join(", ", ArrayMain)}]");

if (Exam(ArrayMain) == true)
{
    Console.WriteLine("В данном массиве присутствует число 5");
}
else
{
    Console.WriteLine("В данном массиве нет числа 5");
}

int[] Array(int number, int minValue, int maxValue)
{
    int[] arrayN = new int[number];
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(minValue, maxValue + 1); //+ 1 чтобы включить в массив девятку
    }
    return arrayN;
}

bool Exam(int[] array)
{
    foreach (int element in array)
    {
        if (element == 5)
        {
            return true;
        }
    }
    return false;
}
*/

// Задайте массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]

/*
int[] ArrayMain = Array(123, -300, 300);

int[] Array(int number, int minValue, int maxValue)
{
    int[] arrayN = new int[number];
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(minValue, maxValue + 1); //+ 1 чтобы включить в массив девятку
    }
    return arrayN;
}

int SearchCount(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
       
        if (element >= 10 && element <= 99)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Количество элементов со значением от 10 до 99 равно {SearchCount(ArrayMain)}");
*/