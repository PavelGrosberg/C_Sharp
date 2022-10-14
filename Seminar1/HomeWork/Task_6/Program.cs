/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
