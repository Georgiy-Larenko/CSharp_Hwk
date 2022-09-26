// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:


//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int n = 4;
int [,] squareArray = new int [n,n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareArray.GetLength(0) * squareArray.GetLength(1))
{
  squareArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < squareArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squareArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squareArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

System.Console.WriteLine();
PrintArray(squareArray);
System.Console.WriteLine();

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