/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 
Например:
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1   */

Console.Write("Enter the number N= ");
int.TryParse(Console.ReadLine()!, out int N);

void ShowNumbers(int n)
{
    if(n == 1) {Console.Write($"{n}"); }
    else {Console.Write($"{n}, "); 
          ShowNumbers(n-1); }
}
Console.Write($"                     -> ");
ShowNumbers(N);
