// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine();
int[,] array = new int[4,5];
Random rand = new Random();

FillArray(array);
PrintArray(array);
FindMinRow(array);

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

void FindMinRow(int[,] array)
{
    int minrow = 0;
    int summin = 0;
    int sumtemp = 0;
    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i,j];
        }
        Console.WriteLine($"Сумма {i+1} строки: {sumrow}");
        if (sumrow < sumtemp)
        {
            summin = sumrow;
            minrow = i;
        }
        sumtemp = sumrow;
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшаяя сумма = {summin}");
    Console.WriteLine($"Номер строки = {minrow+1}");
}