int size = 8;
int[] a = new int[size];
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0, 2);
    System.Console.Write(a[i] + " ");
}