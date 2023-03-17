// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
// числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void Numbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0 && m >= 0)
    {
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
    else
        Numbers(m + 1, n);        
}

Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Чётные натуральные числа в промежутке от {m} до {n}: ");

Numbers(m, n);
