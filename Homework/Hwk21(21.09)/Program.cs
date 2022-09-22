// Задача 50. Напишите программу, которая на вход принимает позиции(индекс строки и столбца) элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int [,] result = GetArray(rows,columns);

int[,] GetArray(int rows, int columns)
{
    int [,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i,j] = new Random().Next(21); 
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    
}

PrintArray(result);
Console.WriteLine();

Console.Write("Введите индекс строки: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (n > rows || m > columns) Console.Write("Такого элемента нет");
else Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {result[n-1,m-1]}");

