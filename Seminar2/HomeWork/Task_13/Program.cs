/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number.Length < 3) System.Console.WriteLine("Третьей цифры нет");
else System.Console.WriteLine(number[2]);
