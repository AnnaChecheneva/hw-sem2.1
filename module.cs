Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, te!");
// Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    n = -n ;
    System.Console.WriteLine($" Модуль числа {-n} равен {n} ");
}
else 
{
    System.Console.WriteLine($" Модуль числа {n} равен {n} ");
}
