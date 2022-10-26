int x1 = ReadInt("Введите Х точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите Х точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int sqrLenghtX = (x2 - x1) * (x2 - x1);
int sqrLenghtY = (y2 - y1) * (y2 - y1);
double distance = Math.Sqrt(sqrLenghtX + sqrLenghtY);
System.Console.WriteLine("Расстояние равно " + distance);

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
