/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] SetInt2DArray(int m, int n) 
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void MinSumLineArray(int [,] array)
{   
    int[] lineArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int lineSum = 0;      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSum += array[i,j];           
        }
        Console.WriteLine($"{lineSum} -> {i + 1} строка");
        lineArray[i] = lineSum;
    } 
    int lineNumber = Array.IndexOf(lineArray, lineArray.Min());
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {lineNumber + 1} строка");
}

MinSumLineArray(SetInt2DArray(4,4));
