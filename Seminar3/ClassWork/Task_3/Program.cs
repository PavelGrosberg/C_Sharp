Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= number)
{
    System.Console.Write(i * i);
    if (i < number) Console.Write(", ");
    i++;
}