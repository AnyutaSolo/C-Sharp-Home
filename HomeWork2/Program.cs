//Задача4 Напишите программу, которая принемает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Input integer three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ed = ((number % 100)/10);

Console.WriteLine($"Last digit is {ed}");


