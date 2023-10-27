/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void rec (int N)
{
    if (N == 0)
        return;
    Console.Write($"{N} ");
    rec (N-1);
}

int N = Convert.ToInt32(Console.ReadLine());
rec(N);



Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int summ (int M, int N)
{
    if (M == N)
        return M;
    return M + summ(M+1, N);
}

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summ(M, N));



Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int A (int M, int N)
{
    if (M == 0)
        return N+1;
    if (N == 0)
        return A(M-1, 1);
    return A(M-1, A(M, N-1));
}

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(M, N));