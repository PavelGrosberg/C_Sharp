Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int sum = 0;

/*
int i = 1;
while (i <= number)
{
    sum += i;
    i++;
}
*/

for (int i = 1; i <= number; i++)
{
    sum += i;
}

System.Console.WriteLine(sum);