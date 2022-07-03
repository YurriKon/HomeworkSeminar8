// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.WriteLine();

int[,] array = new int[4,5];
Random rand = new Random();



void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j = 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,minPosition])
                {
                    minPosition = j;
                }
            }
            int temporary = array[i,j];
            array[i,j] = array[i,minPosition];
            array[i,minPosition] = temporary;
        }
    }
}
void PrintArraySorted(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
    }
}