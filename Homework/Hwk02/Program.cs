// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите 3 числа числа : ");
string[] num = Console.ReadLine().Split(' ');
               int num1 = int.Parse(num[0]);
               int num2 = int.Parse(num[1]);
               int num3 = int.Parse(num [2]);

int max = 0;

if (num1 > num2 && num1 > num3)
{
    max = num1;
    Console.Write($"Max number: {max}");
}
if (num2 > num1 && num2 > num3)
{
    max = num2;
    Console.Write($"Max number: {max}");
}
if (num3 > num1 && num3 > num2)
{
    max = num3;
    Console.Write($"Max number: {max}");
}