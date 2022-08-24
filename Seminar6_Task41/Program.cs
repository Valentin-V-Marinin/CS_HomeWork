// Домашнее задание
// Семинар 6, Задача 41
// Ввод М чисел с клавиатуры, нахождение количества введённых чисел больше нуля

Console.WriteLine("Сколько чисел будет введено?");
int number = Convert.ToInt32(Console.ReadLine());
int [] inputArray = new int[number];
int positiveNumber = 0;

for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Введите {i + 1}-е число");
    inputArray[i] = Convert.ToInt32(Console.ReadLine());
    if (inputArray[i] > 0) positiveNumber++;
}

Console.WriteLine("[" + string.Join(", ", inputArray) + "]");
Console.WriteLine($"Введено чисел больше нуля: {positiveNumber}");

