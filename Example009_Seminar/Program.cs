//однострочный комментарий

/* многострочный 
комментарий
*/

//Напишите программу, которая на вход принимает число и выдаёт его квадрат

//Вариант 1

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

Console.WriteLine($"Квадрат числа {number} равен {sqr}");


