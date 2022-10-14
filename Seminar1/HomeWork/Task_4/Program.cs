// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);
