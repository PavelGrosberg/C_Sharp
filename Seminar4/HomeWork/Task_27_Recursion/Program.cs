/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumDig(n);
System.Console.WriteLine($"{n} -> {sum}");


int SumDig (int tempN) 
{ 
    if (tempN == 0) return 0;
    return (tempN % 10 + SumDig(tempN/10));
}
