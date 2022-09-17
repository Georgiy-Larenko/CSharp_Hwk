// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;

int[] array = new int[size];  

for (int i = 0; i < array.Length; i++) 

{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");   
    if (array[i] % 2 == 0) count +=1;

}

Console.WriteLine();
if (count > 0) Console.WriteLine($"Количество четных чисел в массиве: {count}");
else Console.WriteLine($"Четных чисел в массиве нет");