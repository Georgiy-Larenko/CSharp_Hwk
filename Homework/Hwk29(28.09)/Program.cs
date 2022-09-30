// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30






Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
    int s = 0;
    for (int i = m; i <= n; i++)
    {
        if (i % 1 == 0)
        s=s+i; 
    }
    return s;  
}

System.Console.WriteLine(SumRec(m,n));
