/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
массиве, и возвращает значение этого элемента или же указание, что такого элемента 
нет. Во вводе первая цифра - номер строки, вторая - столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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
    return array;
}

void ShowMatrixElement (int[,] array, int m, int n)
{ 
    if (m >= array.GetLength(0)) Console.WriteLine($"{m}{n} -> Такого числа нет в массиве");
    else if (n >= array.GetLength(1)) Console.WriteLine($"{m}{n} -> Такого числа нет в массиве");
    else Console.WriteLine($"{m}{n} -> {array[m, n]}");   
}

ShowMatrixElement(SetInt2DArray(5, 5), 2, 2);
