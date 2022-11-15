/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] SetArray(int N, int min = 100, int max = 1000)
{
   int[] nums = new int[N];
   for (int i = 0; i < N; i++)
   {
        nums[i] = new Random().Next(min, max);
   }
   for (int i = 0; i < N; i++)
   {
        if (i == 0) System.Console.Write($"[{nums[i]}, ");
        else if (i == N - 1) System.Console.Write($"{nums[i]}] -> ");
        else System.Console.Write($"{nums[i]}, "); 
   }   
   return nums;
}

int GetOddSum (int[] array)
{
    int oddSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0) oddSum += array[i];
    }
    System.Console.Write($"{oddSum}");
    return oddSum;
}

GetOddSum(SetArray(5, -99, 99));

