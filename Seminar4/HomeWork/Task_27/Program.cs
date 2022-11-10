/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int tempN = n;
while (tempN > 0)
{
    int digit = tempN % 10;
    tempN /= 10;
    sum +=digit ;
}

System.Console.WriteLine($"{n} -> {sum}");
