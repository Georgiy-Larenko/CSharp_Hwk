// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат возведения числа {a} в степень {b}: {Math.Pow(a,b)} "); 

Console.WriteLine();



// Или 



Console.Write("Введите первое число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат возведения числа {a} в степень от 1 до {b}: "); 

for (int start = 1; start <= d; start++)
{

   Console.Write(Math.Pow(c,start) + " ");

}

Console.WriteLine();



// Или



Console.Write("Введите первое число: ");
int E = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int F = Convert.ToInt32(Console.ReadLine());



int Exponent(int E, int F)
{
   int result = 1;
   for (int i = 1; i <= F; i++)
   {
      result = result*E;
   }
   return result;
}

Console.WriteLine($"Результат возведения числа {E} в степень {F}: {Exponent(E,F)} ");