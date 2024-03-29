﻿// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int M = Prompt("введите число M = ");
int N = Prompt("введите число N = ");

int Akkerman(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akkerman(M - 1, 1);
  else return Akkerman(M - 1, Akkerman(M, N - 1));
}

int function = Akkerman(M, N);
Console.Write($"A(M,N) = {function} ");