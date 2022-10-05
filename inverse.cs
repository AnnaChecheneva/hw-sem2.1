// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

Console.WriteLine("Hello, Vladimir!");
System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int o = 1;
Console.WriteLine($" Обратным значением числа {n} является {(double) o / n}! ");