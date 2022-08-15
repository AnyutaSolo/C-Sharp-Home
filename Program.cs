# HomeWork

//Задача1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"The first number is greater than the second");
}
else if (num1 < num2)
{
    Console.WriteLine($"The first number is less than the second");
}
else
{
    Console.WriteLine($"Both numbers are equal");
}
*/
//Задача2  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input ferst number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.Write($"maximum number = {max}");
*/
//Задача3  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int even = a % 2;

if (even == 0)
{
    Console.Write($"namber {a} - even");
}
else
{
    Console.Write($"namber {a} - not even");
}
*/
//Задача4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = n * (1);

while(current <= n)
if (current %2 == 0)
{
    Console.Write(current + " ");
    current++;
}
*/