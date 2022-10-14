// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число 1: ");
string input1 = Console.ReadLine();
int number = Convert.ToInt32(input);
int sqrNumber = number * number;
Console.WriteLine("Квадрат числа " + number + " равен " + sqrNumber);
