/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.WriteLine("Введите значение 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max ) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);