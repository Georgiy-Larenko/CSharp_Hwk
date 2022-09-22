// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetArray(rows, columns);

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(21);
        }
    }
    return array;
}

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

Console.WriteLine();
PrintArray(result);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < result.GetLength(0); i++)
{
    double avrg = 0;
    for (int j = 0; j < result.GetLength(1); j++)
    {
        avrg = avrg + result [i,j] ;
    }
    avrg = avrg / rows;
    string res = string.Format("{0:F3}",avrg);
    Console.Write(res + "\t");
}
