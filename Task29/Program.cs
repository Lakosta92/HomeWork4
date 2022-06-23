// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] array = new int[8]; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(31);
    
}
PrintArray(array);

void PrintArray (int []arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}
