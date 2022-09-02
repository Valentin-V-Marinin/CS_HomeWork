// Домашнее задание
// Семинар 8, Задача 66
// Задать значения M и N. Написать программу, которая найдёт сумму натуральных элементов в промежутке от M до N
 
Console.WriteLine("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());
int sumMN = 0;


int Summa(int m, int n)
{
    if (m == n-1) return 0;
    Summa(m-1, n);
    return sumMN += m;
}

if (N > M) {(N,M) = (M,N);}
Console.WriteLine(Summa(M,N));