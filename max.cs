Console.WriteLine("Hello, Vladimir!");
Console.WriteLine("Hello, World!");
System.Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine($"Число {a} больше числа {b}!");
}
else
{
    System.Console.WriteLine($"Число {b} больше числа {a}!");
}