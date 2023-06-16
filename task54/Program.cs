// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
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
void FindAveregeOfColumn(int[,] array)
{
    int[] rowStorage = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowStorage[j] = array[i, j];
            
        }
        SortArray(rowStorage);
        Console.WriteLine();
        PrintArray(rowStorage);
    }
}
void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i -1; j++)
        {
            if (array[j] < array[j+1])
            {
                int temp = array[j+1];
                array[j+1] = array[j];
                array[j] = temp;
                    
            }
        }
    }   
}
int[,] newArray = CreateArray(4, 5);
FindAveregeOfColumn(newArray);