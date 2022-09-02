// Домашнее задание
// Семинар 8, Задача 64
// Задать значение N. Написать программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

void PrintN(int N)
{
    if (N == 0) return;
    Console.Write(N + " ");
    PrintN(N-1);
}

PrintN(N);
Console.WriteLine();