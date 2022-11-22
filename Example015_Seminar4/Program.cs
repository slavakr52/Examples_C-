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

// Задача 30:   Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.   [1,0,1,1,0,1,0,0]
/* int[] array = new int[8];
Mass(array);
Console.WriteLine($"Массив:  {String.Join("  ",array)}");

int[] Mass(int[] array){
    for(int i=0; i<array.Length; i++){
        array[i] = new Random().Next(0,2);
    }
    return array;
} */


/// Задача 28: Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100.

/*
int[] arr= array(10);
Console.WriteLine($"Массив [{String.Join(", ",arr)}]");
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение элементов меньше {Num} следующее {arrayPr(arr, Num)}");

int[] array(int number){  // Заполнение массива
    int[] array1= new int[number];
     for(int i=0; i<array1.Length; i++){
        array1[i] = new Random().Next(50,101);
    }
    return array1;
}
int arrayPr(int[] array, int number){  // Произведение элементов
    int Proizv=1;
     for(int i=0; i<array.Length; i++){
        if (array[i]<number){
            Proizv=Proizv*array[i];
        }
       }
    return Proizv;
}
*/