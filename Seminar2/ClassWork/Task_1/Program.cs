/*Напишите программу, которая будет принимать на вход два
числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

int min = 10;
int max = 99;
int randomNumber1 = new Random().Next(min, max + 1);
int randomNumber2 = new Random().Next(min, max + 1);

// Console.WriteLine(randomNumber1);
// Console.WriteLine(randomNumber2);


if (randomNumber1 % randomNumber2 == 0)
{
    Console.WriteLine($"{randomNumber1}, {randomNumber2} -> {randomNumber1 / randomNumber2}");
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"{randomNumber1}, {randomNumber2} -> {randomNumber1 % randomNumber2}");
}

