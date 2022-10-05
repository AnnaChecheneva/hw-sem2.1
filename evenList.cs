// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Vladimir!");
// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
double h = N % 2;
System.Console.WriteLine($"Остаток при делении на два {h}!");
if ( h == 0 )
{
    System.Console.WriteLine($"{N} четное число!");
}
else
{
    N = N - 1;
}
System.Console.WriteLine($"Все чётные числа от 1 до {N + 1}: ");
while (N > 0)
{
    System.Console.Write($"{N}, ");
    N = N - 2;
}

