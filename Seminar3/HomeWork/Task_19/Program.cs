/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstThreeDigits = number / 100;
int lastThreeDigits = number % 1000;

int i = 1;
int digitMultiplier = 100;
int lastThreeDigitsReversed = 0; 
int tempNumber = number;

while (i <= 3)
{
    int temp = tempNumber % 10;
    tempNumber /= 10;
    lastThreeDigitsReversed += temp * digitMultiplier;
    digitMultiplier /= 10;
    i++;
}

if (firstThreeDigits == lastThreeDigitsReversed) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");
