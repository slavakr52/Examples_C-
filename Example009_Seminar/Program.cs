//однострочный комментарий

/* многострочный 
комментарий
*/

//Напишите программу, которая на вход принимает число и выдаёт его квадрат

//Вариант 1

/* 
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
*/

//Вариант 2 с использованием библиотек

/*
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");
*/

//Задача: ввести число X, на выводе получить интервал от -X до X

/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = -N;
while (N2 <= N)
{
    Console.Write($"{N2} ");
    N2++;
}
*/

//Задача: принять на вводе трехзначное число и вывести его последнюю цифру

/*
Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine()!);
int S = N%10;
Console.Write($"Последняя цифра числа: {S}");
*/

//Задача: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*
Console.WriteLine("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine()!);
int N3 = N2*N2;

if (N3 == N1)
{
    Console.WriteLine("Да");
}
else
    Console.WriteLine("Нет ");
*/

//Задача: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

/*
Console.WriteLine("Введите номер дня недели: ");
int N = int.Parse(Console.ReadLine()!);

if (N == 1) Console.Write ("Понедельник");
if (N == 2) Console.Write ("Вторник");
if (N == 3) Console.Write ("Среда");
if (N == 4) Console.Write ("Четверг");
if (N == 5) Console.Write ("Пятница");
if (N == 6) Console.Write ("Суббота");
if (N == 7) Console.Write ("Воскресенье");
*/