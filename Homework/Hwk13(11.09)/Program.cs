// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

//   int GetCountSum(int number)
// {
    
//     int count = Convert.ToString(number).Length;
//     int adv = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//   {
//       adv = number - number % 10;
//       result = result + (number - adv);
//       number /= 10;
//   }
//    return result;
// }

// Console.WriteLine($"Сумма цифр в числе {number}: {GetCountSum(number)}");
// Console.WriteLine();


// Или



Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers(int num) 
{
    
    int adv = 0;
    int result = 0;
    while(num > 0)
    {    
        adv = num - num % 10;
        result = result + (num - adv);
        num /= 10;
    }
    return result;
}

Console.WriteLine(GetCountNumbers(num));