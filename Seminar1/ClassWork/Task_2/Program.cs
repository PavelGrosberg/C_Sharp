string wd1 = "Понедельник";
string wd2 = "Вторник";
string wd3 = "Среда";
string wd4 = "Четверг";
string wd5 = "Пятница";
string wd6 = "Суббота";
string wd7 = "Воскресенье";

Console.WriteLine("Введите число от 1 до 7");

int num = Convert.ToInt32 (Console.ReadLine());


if (num == 1) {
    Console.WriteLine(wd1);
}
else if (num == 2) {
    Console.WriteLine(wd2);
}
else if (num == 3) {
    Console.WriteLine(wd3);
}
else if (num == 4) {
    Console.WriteLine(wd4);
}
else if (num == 5) {
    Console.WriteLine(wd5);
}
else if (num == 6) {
    Console.WriteLine(wd6);
}
else if (num == 7) {
    Console.WriteLine(wd7);
}
else {
Console.WriteLine("Неверное число");
}
