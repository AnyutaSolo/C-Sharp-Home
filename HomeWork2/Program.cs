//Задача1 Напишите программу, которая принемает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


int MiddleDigit (int number)
{
    int dec = number / 10 % 10;
    return dec;
}
int randomNumber = new Random().Next(100, 1000);
int newNumber = MiddleDigit(randomNumber);
Console.WriteLine($"{newNumber} it the third digit of {randomNumber}");


// Задача2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что других цифр нет.


Console.Write("Input a number: ");

int number = Convert.ToInt32(Console.ReadLine());

int currentNumber = number;

if (number < 100)
{
    Console.WriteLine($"{currentNumber} doesn't contain the third digit");
}

while (number > 1000)
{
    currentNumber = number / 10;

    if(number<= 1000)
     Console.WriteLine($"The third digit of {number} is {number % 10}"); 
}


//Задача3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool FindWeekend (int dayNumber)
{
    if(dayNumber >= 6)
    return true;

    else 
    return false;
}
Console.Write("Input any number of a week day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool FindDay = FindWeekend(dayNumber);
Console.WriteLine(FindDay);
