Console.WriteLine("Введите число a: ");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
Console.WriteLine("Введите число b: ");
string inputB = Console.ReadLine();
int b = Convert.ToInt32(inputB);
if (b == a * a) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}