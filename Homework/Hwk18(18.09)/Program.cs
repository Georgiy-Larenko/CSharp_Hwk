// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение элемента массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Итоговый массив: ");
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine("\n" + $"Количество чисел больше 0: {count}");