// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2) 
{
    max = num1;
    Console.Write($"Максимальное число {max}");
}
else 
{
    max = num2;
    Console.Write($"Максимальное число {max}");
}