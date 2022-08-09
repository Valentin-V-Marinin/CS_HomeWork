// Домашнее задание
// Семинар 2, Задача 13 (альтернативный вариант)
// Вывод третьей цифры заданного числа или вывод сообщения о её отсутствии

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) < 100)
{
    Console.WriteLine($"У введенного числа {number} нет третьей цифры.");
}
else
{
    int n3 = Math.Abs(number%10);
    int number_aux = number;
    while (Math.Abs(number_aux) > 1000)
    {
        number_aux = number_aux/10;
        n3 = Math.Abs(number_aux%10);
    }
    Console.WriteLine($"Третьей цифрой введенного числа {number} является {n3}.");
}
