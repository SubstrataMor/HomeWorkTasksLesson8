// Задача 60. *** ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x,y,z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] FillRandom()
{
    Random random = new Random();
    int[,,] array3D = new int[2,2,2];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {                            
                int randNumber = random.Next(10, 100);
                while (Array3DContains(array3D, randNumber))
                {
                    randNumber = random.Next(10, 100);
                }
            array3D[i, j, k] = randNumber;
            }
        }
    }
    return array3D;
}
bool Array3DContains(int[,,] array3D, int randNumber)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == randNumber)
                return true;
            }
        }
    }
    return false;
}
int[,,] newArray3D = FillRandom();
PrintArray(newArray3D);