/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] setArray(int N, int min, int max)
{
   int[] nums = new int[N];
   for (int i = 0; i < N; i++)
   {
        nums[i] = new Random().Next(min, max);
        if (i == N - 1) System.Console.Write($"{nums[i]} -> "); 
        else System.Console.Write($"{nums[i]}, ");
   }
   for (int i = 0; i < N; i++)
   {
        if (i == 0) System.Console.Write($"[{nums[i]}, ");
        else if (i == N - 1) System.Console.Write($"{nums[i]}]");
        else System.Console.Write($"{nums[i]}, "); 
   }
   
   return nums;
}


setArray(10, 1, 10);
