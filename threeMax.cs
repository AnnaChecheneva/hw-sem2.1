Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Vladimir!");
// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max > b )
{
    a = max;
}
else
{
    max = b;
}
if (max > c)
{
    System.Console.WriteLine($"Максимальным числом из {a}, {b}, {c} является {max}");
}
else
{
    max = c;
    System.Console.WriteLine($"Максимальным числом из {a}, {b}, {c} является {max}");
}