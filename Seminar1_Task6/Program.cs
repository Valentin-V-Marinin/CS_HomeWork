// Домашнее задание
// Семинар 1, Задача 6
// Определение четности введенного числа

Console.WriteLine("Введите число");
int number = Convert.ToInt32( Console.ReadLine() );

if ((number % 2) == 0) 
    {
        Console.WriteLine("Введеннле число является четным");
    }
else
    {
        Console.WriteLine("Введеннле число не является четным");
    };

