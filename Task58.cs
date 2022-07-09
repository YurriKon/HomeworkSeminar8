// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
// ! самостоятельно решить не смог, воспользовался Google и разбором д/з.

Console.WriteLine();

    int sizeX = 4, sizeY = 4;
    int[,] array = new int[sizeX, sizeY];
    int indexX = 0, indexY = 0, changeX = 0, changeY = 1, rotate = 0, steps = sizeY;
 
    for (int i = 0; i < array.Length; i++)
    {
        array[indexX,indexY] = i + 1;
        steps--;
        if (steps == 0)
        {
            steps = sizeX - 1 - rotate/2;
            int temp = changeX;
            changeX = changeY;
            changeY = -temp;
            rotate++;
        }
            indexX += changeX;
            indexY += changeY;
    }
 
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
 