/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/


int randomThreeDigitNumber = RandomThreeDigitNumber();
int secondDigit = randomThreeDigitNumber / 10 % 10;
System.Console.WriteLine($"{randomThreeDigitNumber} -> {secondDigit}");


int RandomThreeDigitNumber () {
    int min = 100;
    int max = 1000;
    int randomNumber = new Random().Next(min, max);
    return randomNumber;
}
