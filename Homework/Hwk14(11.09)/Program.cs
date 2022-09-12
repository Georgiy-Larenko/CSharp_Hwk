// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите значение длинны массива чисел от 1 до 100: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
        
    }
    return array;
}

int[] resultArray = GetArray(size);

Console.WriteLine($"Созданный массив, длинной {size} элементов: [{String.Join(", ", resultArray)}]");