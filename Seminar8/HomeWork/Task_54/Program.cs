/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

void ReverseSort (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {                  
        for (int sortIter = 0; sortIter < array.GetLength(1); sortIter++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = 0;
                if (j + 1 < array.GetLength(1))
                {
                    if (array[i, j] < array[i, j + 1])
                    {
                        temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }   
                }
            }
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
}


ReverseSort(SetInt2DArray(3,4));
