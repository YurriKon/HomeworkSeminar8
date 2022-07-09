// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

Console.WriteLine();

int[,] array = new int[4,5];
Random rand = new Random();

FillArray(array);
PrintArray(array);
SortRowArray(array);
PrintArraySorted(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Заданный массив:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,maxPosition])
                {
                    maxPosition = k;
                }
            }
                int temporary = array[i,j];
                array[i,j] = array[i,maxPosition];
                array[i,maxPosition] = temporary;
        }
    }
}

void PrintArraySorted(int[,] array)
{
    Console.WriteLine("Отсортированный массив:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}