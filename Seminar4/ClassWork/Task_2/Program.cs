Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 1; i <= number; i++)
{
    sum *= i;
}

System.Console.WriteLine(sum);