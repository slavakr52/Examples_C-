// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от 1 до N


// Console.WriteLine("Введите число:");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(1, N));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }



// *Задача 65:** Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите начало промежутка:");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите конец промежутка:");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(M, N));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Напишите программу, которая будет принимать на вход число и 
//возвращать сумму его цифр.

// Console.WriteLine("Введите число");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Sum(M));

// int Sum(int M)
// {
//     if (M == 0) return 0;
//     return ((M % 10) + Sum(M / 10));
// }

// Напишите программу, которая на вход принимает два числа A и B, и 
//возводит число А в целую степень B с помощью рекурсии.

// Console.WriteLine("Введите число:");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень:");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(NumPow(M, N));

// int NumPow(int N, int S)
// {
//     if (S == 0) return 1;
//     if (S == 1) return N;
//     return (N * NumPow(N, S - 1));
// }




