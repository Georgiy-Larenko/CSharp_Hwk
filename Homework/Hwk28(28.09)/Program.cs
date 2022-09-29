// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int b = 1;

string NumbersRec (int n, int b)
{
    if (n<=b) return NumbersRec(n+1,b) + $"{n} ";
    else return string.Empty;
}

Console.Write($"Натуральные числа от {n} до {b}: ");
Console.WriteLine(NumbersRec(b,n));