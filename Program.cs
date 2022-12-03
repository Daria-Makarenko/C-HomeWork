// Домашняя работа 1 

// Задача 1 - Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num1;
if(num2 > max) max = num2; 
if(num2 < min) min = num2;
{
    Console.WriteLine($"max = {max}, min = {min}");
}
*/

// Задача 2 - Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > max) 
    max = num2;
if(num3 > max) 
    max = num3;
{
    Console.WriteLine(max);
}
*/

// Задача 3 - Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

// Задача 4 - Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;
int step = 2;
while(current <= num)
{
    Console.Write(current + " ");
    current += step;
}
*/