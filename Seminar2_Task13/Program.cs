// Домашнее задание
// Семинар 2, Задача 13
// Вывод третьей цифры заданного числа или вывод сообщения о её отсутствии

Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (Convert.ToInt32(number) > 0)
{
    if (number.Length < 3)
        {Console.WriteLine($"В числе {number} нет третьей цифры");}
    else
        {Console.WriteLine($"В числе {number} третьей цифрой является {number[2]}");}
}
else
{
    if (number.Length < 4)
        {Console.WriteLine($"В числе {number} нет третьей цифры");}
    else
        {Console.WriteLine($"В числе {number} третьей цифрой является {number[3]}");}
}