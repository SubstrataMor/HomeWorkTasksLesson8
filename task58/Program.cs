// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 4);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}
void ResultMatrix(int[,] m1, int[,] m2)
{
    int[,] resultArray = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            for (int k = 0; k < m2.GetLength(1); k++)
            {
                resultArray[i,j] += m1[i,k] * m2[k,j];
                
            }
            Console.Write($"{resultArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix1 = CreateArray(3,3);
Console.WriteLine();
int[,] matrix2 = CreateArray(3,3);
Console.WriteLine();
ResultMatrix(matrix1, matrix2);