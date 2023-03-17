// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int M = Prompt("введите число M = ");
int N = Prompt("введите число N = ");

int temp = M;

if (M> N) 
{
  M = N; 
  N = temp;
}

PrintResult(M, N, temp = 0);

void PrintResult(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"сумму натуральных элементов в промежутке от M до N -> {summ} ");
    return;
  }
  PrintResult(M, N - 1, summ);
}
