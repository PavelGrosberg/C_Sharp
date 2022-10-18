/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99) {
    int digit = GetSecondDigit(number);
    System.Console.WriteLine($"{number} -> {digit}");
}

else System.Console.WriteLine($"{number} -> третьей цифры нет");


static int GetSecondDigit(int k) {
    while (k >= 1000) k /= 10;
    int d = k % 10;
    return d;
}
    