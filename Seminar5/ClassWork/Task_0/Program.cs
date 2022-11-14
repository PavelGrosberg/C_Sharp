int size = 12;
int min = -9;
int max = 9;
int[] numbers = new int[size];
int posSum = 0;
int negSum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min, max + 1);
}
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
        negSum += numbers[i];
    else 
    posSum += numbers[i];
}
Console.WriteLine($"Положительная сумма = {posSum}, отрицательная сумма = {negSum}");

void WriteArray(int[] array)
{
    for (i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");       
    }
    Console.WriteLine();
}   
