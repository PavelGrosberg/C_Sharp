/*Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NaturalNumbersSumFromRange (int M, int N)
{
    if (M == N) return N;     
    return N += NaturalNumbersSumFromRange(M, N - 1);
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}; N = {N} -> {NaturalNumbersSumFromRange(M, N)}");
