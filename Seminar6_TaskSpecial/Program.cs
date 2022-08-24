// Домашнее задание
// Семинар 6, Задача Дополнительная на рекурсию
// Написать программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число для расчёта факториала:");
int number = Convert.ToInt32(Console.ReadLine());

int MyFactorial(int numb)
{
    int result = 1;
    if (numb == 1 || numb == 0) result = 1;
    else result = numb * MyFactorial(numb - 1);
    return result;
}

Console.WriteLine(MyFactorial(number));
