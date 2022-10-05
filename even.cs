// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
double i = n % 2;
System.Console.WriteLine($"Остаток {i}!");
if ( i == 0 )
{
    System.Console.WriteLine($"{n} четное число!");
}
else
{
    System.Console.WriteLine($"{n} нечетное число!");
}

