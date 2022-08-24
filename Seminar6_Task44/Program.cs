// Домашнее задание
// Семинар 6, Задача 44
// Не используя рекурсию, вывести первые N чисел Фибоначчи

Console.WriteLine("Введите количестов чисел Фибоначчи для вывода (число N)");
int number = Convert.ToInt32(Console.ReadLine());
int [] arrFibonacci = new int[number];

for (int i = 0; i < number; i++)
{
    if (i < 2) arrFibonacci[i] = i;
    else arrFibonacci[i] = arrFibonacci[i-1] + arrFibonacci[i-2];
}

Console.WriteLine($"Вывод последовательности чисел Фибоначчи ({number} первых членов).)");
Console.WriteLine("["+ string.Join(", ", arrFibonacci)+ "]");



