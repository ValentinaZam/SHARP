//Напишите программу, которая на вход принимает число и выдает его квадрат.
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");
