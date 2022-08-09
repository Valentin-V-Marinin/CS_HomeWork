// Домашнее задание
// Семинар 2, Задача 10
// Ввод трехзначного числа, вывод его второй цифры

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 & number < 1000) || (number > -1000 & number < -99))
{
    Console.WriteLine($"Вторая цифра числа {number} - {Math.Abs((number/10)%10)}");
}
else
{
    Console.WriteLine($"Введенное число {number} не является трехзначным");
}