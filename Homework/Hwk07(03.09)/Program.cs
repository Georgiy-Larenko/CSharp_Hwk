// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7 : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num == 6) Console.WriteLine($"Число {num} является выходным днем недели. Это - суббота.");

    if (num == 7) Console.WriteLine($"Число {num} является выходным днем недели. Это - воскресенье.");

    if (num != 6 && num != 7) Console.WriteLine($"Число {num} не является выходным днем недели.");
}

else Console.WriteLine($"Вы ввели неправильное число");

   
