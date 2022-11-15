// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

//456 -> 46

/*
int number = new Random().Next(100,1000);
Console.WriteLine($"Число {number} без второй цифры равно {number/100}{number%10}");
*/

//Второй метод

/*
Console.WriteLine("Введите трёхзначное число: ");
string Numbers = Console.ReadLine()!;

if(Numbers.Length != 3)
{
    Console.WriteLine("Введено неверное число!");
}
else
{
    Console.WriteLine($"Число без второй цифры равно {Numbers[0]}{Numbers[2]}");

}
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int number = new Random().Next(10,100);
int number1 = number/10;
int number2 = number%10;

if (number1>number2)
{
    Console.WriteLine($"Максимальная цифра - {number1}");
}
else 
{
    Console.WriteLine($"Максимальная цифра - {number2}");
}
*/



//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

/*
Console.WriteLine("Введите первое число:");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int N2 = int.Parse(Console.ReadLine()!);
int N3 = N1%N2;

if (N1 % N2 == 0)
{
    Console.WriteLine($"Число {N2} является кратным числу {N1}");
}
else
{
    Console.WriteLine($"Остаток от деления числа {N1} на число {N2} равно {N3}");
}
*/

// && - логическое И (выполняются сразу все условия)
// || - логическое ИЛИ (выполняется одно из условий)

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*
Console.WriteLine("Введите число:");
int N1 = int.Parse(Console.ReadLine()!);

if (N1 % 7 == 0 && N1 % 23 == 0)
{
    Console.WriteLine($"Число {N1} является кратным числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {N1} НЕ является кратным числам 7 и 23");
}
*/


//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
Console.WriteLine("Введите первое число:");
int N1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int N2 = int.Parse(Console.ReadLine()!);

if (N1*N1 == N2 || N2*N2 == N1)
{
    Console.WriteLine($"Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine($"Ни одно из чисел не является квадратом другого");
}
*/

