// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[4,5];
Random rand = new Random();

FillArray(array);
PrintArray(array);
FindMinRowArray(array);
/* PrintResult(array); */

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1, 10);
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

void FindMinRowArray(int[,] array)
{
    int sumrow = 0;
    int summin = 0;
    int minrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i,j];
        }
        sumrow = summin;
        if (sumrow < summin) 
        {
            summin = sumrow;
        }
        
        
    }
    Console.WriteLine(summin);
    Console.WriteLine(minrow);
}

/* void PrintResult(int[,] array)
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
*/