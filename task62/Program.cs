// Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputSize()
{
    Console.Write("Задайте размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int[,] SpiralArray(int size)
{
    int[,] array = new int[size,size];
    int n = size*size;
    int value = 0;
    int length = size-1;
    int i = 0;
    int j = 0;
    do
    {
        if (i <= j + 1 && i + j < length)
        {
            array[i,j] = value+1;
            j++;
        }
        else if (i < j && i + j >= length)
        {
            array[i,j] = value+1;
            i++;
        }
        else if (i >= j && i + j > length)
        {
            array[i,j] = value+1;
            j--;
        }
        else 
        {
            array[i,j] = value+1;
            i--;
        }
        value++;
    } while (value < n);
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j].ToString("D2")+" ");
        }
        Console.WriteLine();
    }
}
PrintArray(SpiralArray(InputSize()));