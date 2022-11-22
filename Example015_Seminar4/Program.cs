// Напишите программу, которая принимает на вход число А и выдаёт сумму чисел от 1 до A

/*
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 0; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе {Number} равно {NumberCount(Number)}");

int NumberCount(int limit)
{
    int count = 0;
    for (int i=1; limit!=0; i++)
    {
       limit = limit/10;
       count = i;

    }
    return count;
}
*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

/*
int [] array = new int[8];
ArrayRandom (array);
Console.WriteLine($"Массив: {string.Join("  ",array)}");

int[] ArrayRandom(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
*/

//Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение всех чисел массива, меньше числа {Number}, равно {ArrayRandom()}");