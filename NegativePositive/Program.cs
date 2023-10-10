
using System;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int pos = 0;
int neg = 0;

if (a > 0) pos++; else if (a < 0) neg++;
if (b > 0) pos++; else if (b < 0) neg++;
if (c > 0) pos++; else if (c < 0) neg++;

Console.WriteLine("Положительных: " + pos);
Console.WriteLine("Отрицательных: " + neg);
