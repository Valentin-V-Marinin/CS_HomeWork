// Домашнее задание
// Семинар 2, Задача 15
// Определение выходного дня по введенной цифре дня недели

Console.WriteLine("Введите цифру дня недели 1(пнд)-7(вск) ");
int weekday = Convert.ToInt32(Console.ReadLine());

switch (weekday)
{
    case 1: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует понедельнику. Это не выходной день.");
        break;
    case 2: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует вторнику. Это не выходной день.");
        break;
    case 3: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует среде. Это не выходной день.");
        break;
    case 4: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует четвергу. Это не выходной день.");
        break;
    case 5: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует пятнице. Это не выходной день.");
        break;
    case 6: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует субботе. Это выходной день.");
        break;
    case 7: 
        Console.WriteLine($"Введённая цифра {weekday} соответствует воскресенью. Это выходной день.");
        break;
    default:
        Console.WriteLine($"ОШИБКА! Введённая цифра {weekday} за пределами допустимых значений.");
        break;
}
