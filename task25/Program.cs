// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;
while (true) 
{
    Console.WriteLine($"Введите число, которое хотите возвести в степень и нажмите Enter, если передумали, нажмите Ctrl + C");
    int numA = int.Parse(Console.ReadLine());

    Console.WriteLine($"Введите в какую чтепень хотите возвести {numA}");
    int numB = int.Parse(Console.ReadLine());

    double result = numA;

    for (int i = 0; i < numB - 1; i++)
    {
        result *= result;
    }
    Console.WriteLine($"Готово: {numA} в степени {numB} равно {result}");
}