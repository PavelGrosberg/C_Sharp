/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
            Console.Write(array[i, j] + "      ");
        }
    Console.WriteLine();
    }
    return array;
}

void MatrixColumnAvgSum(int[,] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            if (i == array.GetLength(0) - 1) 
            {
                if (j == array.GetLength(0) - 1) Console.Write($"{Math.Round(sum/array.GetLength(0),1)}. "); 
                else Console.Write($"{Math.Round(sum/array.GetLength(0),1)}; ");
            }
        }
    }
}

MatrixColumnAvgSum(SetInt2DArray(4,4));
