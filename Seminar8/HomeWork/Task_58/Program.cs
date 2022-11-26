/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] FirstMatrix(int m, int n) 
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

int[,] SecondMatrix(int m, int n) 
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

int[,] ResultMatrix(int [,] firstArray, int [,] secondArray)
{   
    int [,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }    
            }
        }       
    }
    else System.Console.WriteLine("Такие матрицы умножать нельзя!");
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {       
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write(resultArray[i, j] + "  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine(); 
    return resultArray;
}

ResultMatrix(FirstMatrix(2,2), SecondMatrix(2,2));
