System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (n > 9)
{
    n /= 10;
    counter++;
}

System.Console.WriteLine(counter);
