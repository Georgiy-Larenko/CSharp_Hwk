// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine();

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns);

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


PrintArray(array);
Console.WriteLine();


// Находим сумму элементов. 

int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}



int minSumLine = 0;
int sumLine = SumLine(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLine(array, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    minSumLine = i;
  }
}

Console.WriteLine("\n" + $"Строка с наименьшей суммой элементов - {minSumLine+1}");
Console.WriteLine("\n" + $"Сумма элементов наименьшей строкий - ({sumLine})");
Console.WriteLine();





