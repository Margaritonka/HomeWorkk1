// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
Console.WriteLine("max = " + x);
if (x < y)
Console.WriteLine("max = " + y);  
if (x <  y)
Console.WriteLine("min = " + x);
if (x > y)
Console.WriteLine("min = " + y);