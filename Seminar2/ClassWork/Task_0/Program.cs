/*11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int min = 100;
int max = 999;
int randomNumber = new Random().Next(min, max + 1);
int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 10;
Console.WriteLine($"{randomNumber} -> {firstDigit}{secondDigit}");
