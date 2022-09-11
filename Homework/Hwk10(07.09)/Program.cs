// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = 1;

Console.Write($"Кубы чисел от 1 до {n}: "); 
while (start <= n)
{
    Console.Write(Math.Pow(start,3) + " ");
    start++;
}

// Или 

Console.Write("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine());

Console.Write($"Кубы чисел от 1 до {end}: "); 
for (int strt = 1; strt <= end; strt++)
{

   Console.Write(Math.Pow(strt,3) + " ");

}