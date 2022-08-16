// Домашнее задание
// Семинар 4, Задача 25
// Приём на вход два числа (A и B) и возводит число A в натуральную степень B.

string[] Arr = {"A", "B"};
int[] ArrNumb = new int [2];
int count = 0;

while (count < 2)
{
    Console.WriteLine($"Введите число {Arr[count]}: ");
    ArrNumb[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}

int result = 1; count = 0;
 
while (count < ArrNumb[1])
{
    result = result * ArrNumb[0];
    count++;
}

Console.WriteLine(result);