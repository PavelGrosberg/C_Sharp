/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

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

void GetEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    System.Console.Write($"{count}");
}

GetEven(SetArray(4));
