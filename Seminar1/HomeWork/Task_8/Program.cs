/*Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 2;
while (counter <= N)
{
    System.Console.WriteLine(counter);
    counter += 2;
}
