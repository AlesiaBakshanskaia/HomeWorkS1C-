﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2){
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else {
    if (num2 > num1){
    Console.WriteLine($"Число {num2} больше числа {num1}");    
    }
    else {
        Console.WriteLine($"Число {num2} равно числу {num1}");
    }
}
