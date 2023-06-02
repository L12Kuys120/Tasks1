/***Задача 0:** 

**Условие:**

Напишите программу, которая на вход принимает число и 
выдаёт его квадрат (число умноженное на само себя).

**Например:**

4 -> 16
-3 -> 9
-7 -> 49*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} рaвен {sqr}");
//Решение с использованием библиотеки 
int sqr1 = Convert.ToInt32(Math.Pow(number, 5));
Console.WriteLine($"Квадрат числа {number} рaвен {sqr1}");


