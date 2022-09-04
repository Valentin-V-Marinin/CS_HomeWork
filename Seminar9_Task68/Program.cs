// Домашнее задание
// Семинар 8, Задача 66
// Написать программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
bool endProgram = false;

int Ackermann(int m, int n)
{
    while (!endProgram)
    {
        if (m == 0 && n > 0)
            {
                n++; endProgram = true;
            } 
        if (m > 0 && n == 0) 
            {
                Ackermann(m-1, 1);
                if (m==1 && n==0) { (m,n)=(n,m);}
            }
        if (m > 0 && n > 0)  
            {
                Ackermann(m-1, Ackermann(m, n-1));
                if (m==1 && n==1) {m=0; n=2;}
            }
    }
    Console.WriteLine("Финал  m="+m + "  n="+n);
    return (m + n);
}

Console.WriteLine(Ackermann(m, n));
