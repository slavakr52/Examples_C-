//Напишите программу, которая по заданному номеру чыетверти показывает диапазон возможных координат точек в этой четверти

/*
Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:
        Console.WriteLine("Это первая четверть");
        break;
    case 2:
        Console.WriteLine("Это вторая четверть");
        break;
    case 3:
        Console.WriteLine("Это третья четверть");
        break;
    case 4:
        Console.WriteLine("Это четвертая четверть");
        break;
    default:
        Console.WriteLine("Такой четверти нет");
        break;
}
*/

//Определить, является ли заданное шестизначное число счастливым. 
//(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

/*
Console.WriteLine("Введите шестизначное число: ");
string Number = Console.ReadLine()!;

int sum1 = Number[0] + Number[1] + Number[2];
int sum2 = Number[3] + Number[4] + Number[5];

if (Number.Length != 6)
{
    Console.WriteLine("Введено неверное число!");
}
else
{
    if (sum1 == sum2)
    {
        Console.WriteLine("Это счастливое число!");
    }
    else
    {
        Console.WriteLine("Число обычное");
    }
}
*/

//Решение математическим способом:

/*
Console.WriteLine("Введите шестизначное число: ");
int A = int.Parse(Console.ReadLine()!);
if (A > 999999 || A < 100000)
{
    Console.WriteLine("Введено непраильное число!");
}
else
{
    int A1 = A % 10;
    A = A / 10;
    int A2 = A % 10;
    A = A / 10;
    int A3 = A % 10;
    A = A / 10;
    int A4 = A % 10;
    A = A / 10;
    int A5 = A % 10;
    A = A / 10;
    int A6 = A % 10;
    if (A1 + A2 + A3 == A4 + A5 + A6)
    {
        Console.WriteLine("Это счастливое число!");
    }
    else
    {
        Console.WriteLine("Это обычное число");
    }
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
Console.WriteLine("Введите координату первой точки по X: ");
int nX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по Y: ");
int nY = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по X: ");
int n2X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по Y: ");
int n2Y = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow(n2X - nX, 2) + Math.Pow(n2Y - nY, 2));

Console.WriteLine($"Длина отрезка между точками равна {AB:f2}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Таблица квадратов от 1 до {N}: ");
for (int i = 1; i < N + 1; i++)
{
    Console.WriteLine($"{Math.Pow(i, 2)}");
}
*/





