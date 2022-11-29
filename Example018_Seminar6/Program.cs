// Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, первый - на последнем)

/*
int Array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] result = ReversedArray(Array);
Console.WriteLine($"[{String.Join(", ", array)}]");

GetArray(size, minValue, maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[] ReversedArray(int[] array)
{
    int[array] = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[array.Length - i - 1];
    }
    return array;
}
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
Console.Write("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine()!);



    if (Number1 < Number2 + Number3 && Number2 < Number1 + Number3 && Number3 < Number1 + Number2)
    {
        Console.WriteLine("Треугольник с такими сторонами существует");
    }
    else Console.WriteLine("Треугольника с такими сторонами не существует");
*/


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*
Console.Write("Введите десятичное число: ");
int Number1 = int.Parse(Console.ReadLine()!);

string db = String.Empty;

while (Number1 > 0)
{
    if (Number1 % 2 != 0) db = "1" + db;
    else db = "0" + db;
    Number1 /= 2;
}

Console.WriteLine($"Число в двоичном виде: {db}");
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*
int f1 = 0;
int f2 = 1;
int fn = 0;
Console.WriteLine($"{f1}");
Console.WriteLine($"{f2}");
for (int i = 0; i < 10; i++)
{
    fn = f1 + f2;
    f1 = f2;
    f2 = fn;
    Console.WriteLine($"{fn}");
}
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] Array = GetArray(10, 0, 20);
int[] Array2 = ArrayCopy(Array);
Console.WriteLine($"Массив: [{String.Join(", ", Array)}]");
Console.WriteLine($"Копия: [{String.Join(", ", Array2)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array1 = new int[size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array1;
}

int[] ArrayCopy(int[] array)
{
    int[] array2 = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        array2[i] = Array[i];
    }
    return array2;
}
*/

