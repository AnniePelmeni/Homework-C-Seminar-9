// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CountSum(int firstNumber, int secondNumber)
{
    if(firstNumber == secondNumber) return firstNumber;
    else return firstNumber + CountSum(firstNumber + 1, secondNumber);
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int t = CountSum(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {t}");