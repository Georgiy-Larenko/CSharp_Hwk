// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 

if (num > 100 && num < 999) 
{
    int firstDigit = num / 10; 
    int finalDigit = firstDigit % 10; 
    Console.WriteLine($"Итоговое число это : {finalDigit}");
}

else Console.WriteLine("Вы ввели не трехзначное число");