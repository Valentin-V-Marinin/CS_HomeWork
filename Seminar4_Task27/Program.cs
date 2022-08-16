// Домашнее задание
// Семинар 4, Задача 27
// Приём на вход числа, вывод суммы его цифр 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string numbStr = Convert.ToString(Math.Abs(number));
int count = 0; 
int sum = 0;

// если введено отрицательное число, считаем первую цифру числа отрицательной
while (count < numbStr.Length)
{
    if (number < 0 & count ==0)
        {sum += Convert.ToInt32("" + numbStr[count]) * -1;}
    else   
        {sum += Convert.ToInt32("" + numbStr[count]);}
    count++;
}

Console.WriteLine($"Сумма цифр числа равна: {sum}");