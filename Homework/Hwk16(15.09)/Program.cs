// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int[] array = new int[size];  


for (int i = 0; i < array.Length; i++) 

{
    array[i] = new Random().Next(-5,5);
    Console.Write(array[i] + " "); 

    if (i % 2 !=0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine("\n" + $"Сумма элементов, стоящих на нечётных позициях: {sum}");

