// Домашнее задание
// Семинар 8, Задача 66
// Написать программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0 )
        {
            return ++n; 
        }
    if (m > 0 && n == 0) 
        {
            return Ackermann(m-1, 1); 
        }
    if   (m > 0 && n > 0)  
        {
            return Ackermann(m-1, Ackermann(m, n-1));
        }
    return n;
}


