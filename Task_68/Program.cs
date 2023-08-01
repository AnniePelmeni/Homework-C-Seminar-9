// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CountAck(int firstNumber, int secondNumber)
{
    if(firstNumber == 0) return secondNumber + 1;
    else if(secondNumber == 0) return CountAck(firstNumber - 1, 1);
    else return CountAck(firstNumber - 1, CountAck (firstNumber, secondNumber - 1));
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int t = CountAck(m, n);
Console.WriteLine($"m = {m}; n= {n} -> A(m,n) = {t}");