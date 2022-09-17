// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = 10;

int[] array = new int[size]; 

for (int i = 0; i < array.Length; i++) 

{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + " ");      
}

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}

int result = max - min;
Console.WriteLine("\n" + $"Разница между максимальным и минимальным значением массива : {result}");