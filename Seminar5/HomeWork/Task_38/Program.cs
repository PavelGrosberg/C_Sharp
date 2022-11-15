/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным значениями элементов массива.
[3 7 22 2 78] -> 76 */

double[] SetArray(int N)
{
   double[] nums = new double[N];
   for (int i = 0; i < N; i++)
   {
        nums[i] = Math.Round(new Random().NextDouble() * 100, 2);
   }
   for (int i = 0; i < N; i++)
   {
        if (i == 0) System.Console.Write($"[{nums[i]}  ");
        else if (i == N - 1) System.Console.Write($"{nums[i]}] -> ");
        else System.Console.Write($"{nums[i]}  "); 
   }   
   return nums;
}

void GetMaxMinDiff(double[] array)
{
    double diff = array.Max() - array.Min(); 
    System.Console.Write($"{diff}");
}

GetMaxMinDiff(SetArray(5));
