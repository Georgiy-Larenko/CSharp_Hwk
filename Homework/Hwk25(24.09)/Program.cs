// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18


Console.WriteLine();

Console.Write("Введите количество строк 1 го массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 1 го массива: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1);


Console.WriteLine();


Console.Write("Введите количество строк 2 го массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 2 го массива: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array2 = GetArray(rows2, columns2);


if (columns1 != rows2)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}


Console.WriteLine();


// Создаем массив.



int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(31);
        }
    }
    return array;
}



// Печатаем массив. 



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

// Выводим на печать два массива

PrintArray(array1);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();


// Ищу произведение двух массивов


int[,] MultArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}


Console.WriteLine("Итоговый массив");
Console.WriteLine();
PrintArray(MultArray(array1, array2));