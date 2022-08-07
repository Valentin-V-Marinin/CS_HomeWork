// Домашнее задание
// Семинар 1, Задача 8
// Вывод списка четных чисел между 1 и введенным числом (number)

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (number > 0)
{
    while (count <= number)
    {
        if (count % 2 == 0) Console.WriteLine(count);
        count++;
    }
}
else
{
    while (count >= number)
    {
        if (count % 2 == 0) Console.WriteLine(count);
        count--;
    }
};

