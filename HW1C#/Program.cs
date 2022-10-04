//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Введите первое число");
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
}*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;

if (num2 > num1){
    max = num2;
}
if (num3 > num2){
    max = num3;
}

Console.WriteLine($"Максимальное число {max}");*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите  число");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0){
    Console.WriteLine($"Число {num} четное");
}
else {
   Console.WriteLine($"Число {num} не четное"); 
}*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите  число");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i < N){
    i = i + 1;
    if (i % 2 == 0){
    Console.Write($"{i} ");
    }
}
Console.WriteLine(" ");
