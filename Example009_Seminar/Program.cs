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

