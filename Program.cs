﻿// Домашняя работа 1 

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

// Домашняя работа № 2

// Задача 1 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSec(int num)
{
    int first = num / 10;
    return first % 10;
}
int num = new Random().Next(100, 1000);
Console.WriteLine("Randome number is " + num);
Console.WriteLine("The result of work is " + FindSec(num));
*/

// Задача 2 - Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Showthird(int number)
{
    if(number < 100) return -1;
    while (number >= 1000)
        {
            number = number / 10;
        }
        int num = number % 10;
        return num;
}

Console.WriteLine("Write your number ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Showthird(number);
Console.WriteLine(Showthird(number));
*/

// Задача 3 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
int Week(int number)
{
    if(number < 6)
    Console.WriteLine("нет");
    else 
    Console.WriteLine("да");
    return number;
}

Console.WriteLine("Введите номерт дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Week(number);
*/

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Домашняя работа № 3

// Задача 1 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Задача 2 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Задача 3 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

