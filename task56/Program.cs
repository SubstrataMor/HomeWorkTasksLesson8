// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}
int[] SummElementsOfRow(int[,] array)
{
    int[] rowStorage = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        rowStorage[i] = summ;
    }
    return rowStorage;
}
void FindRowOfMaximumNumber(int[] array)
{
    int numberOfRow = 1;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) 
        {
            min = array[i];
            numberOfRow = i+1;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов: {numberOfRow} строка:");
}
int[,] newArray = CreateArray(5, 4);
int[] storageArray = SummElementsOfRow(newArray);
FindRowOfMaximumNumber(storageArray);