﻿// Task10
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра числа: ");
Console.WriteLine((number / 10) % 10);