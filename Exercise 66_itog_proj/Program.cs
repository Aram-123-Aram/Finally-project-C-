/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
Например:
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30    */

Console.Write("Enter the first number M= ");
int.TryParse(Console.ReadLine()!, out int M);
Console.Write("Enter the first number N= ");
int.TryParse(Console.ReadLine()!, out int N);

int SumMN(int m, int n)
{
    if (m == n) return m;
    else return m + SumMN(m+1, n);
}
Console.Write($"-> {SumMN(M, N)}");