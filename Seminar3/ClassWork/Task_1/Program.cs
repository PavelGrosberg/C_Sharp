System.Console.WriteLine("введите номер четверти: ");
int squareNumber = Convert.ToInt32(Console.ReadLine());

switch (squareNumber)
{
    case 1:
        System.Console.WriteLine("X > 0, Y > 0");
        break;
    case 2:
        System.Console.WriteLine("X < 0, Y > 0");
        break;
    case 3:
        System.Console.WriteLine("X < 0, Y < 0");
        break;
    case 4:
        System.Console.WriteLine("X > 0, Y < 0");
        break;
    default:
        System.Console.WriteLine("Четвертей всего 4");
        break;
}
