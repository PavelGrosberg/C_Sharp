/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.*/

System.Console.WriteLine("Введите день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 1 || dayNumber > 7) {
    System.Console.WriteLine("Неверный ввод");
}
else if (dayNumber == 6 || dayNumber == 7) {
    System.Console.WriteLine($"{dayNumber} -> да");
}
else {
    System.Console.WriteLine($"{dayNumber} -> нет");    
}
