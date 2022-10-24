System.Console.WriteLine("введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("X и Y не должны быть равны нулю");
    return;
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}
