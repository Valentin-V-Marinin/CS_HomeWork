// Домашнее задание
// Семинар 5, Задача 35
// Генерация массива со 123 случайными числами,
//   вывод количества чисел в массиве в диапазоне от 10 до 99 

int Number = 0;
int[] arr = new int [123];
Random Rand = new Random();

for(int i = 0; i < 123; i++)
{
    arr[i] = Rand.Next(-200,201);
    if (arr[i] > 9 & arr[i] < 100) Number+= 1;
}

Console.WriteLine("[" + string.Join(", ", arr) +"]");
Console.WriteLine($"Количество чисел в массиве в диапазоне [10-99]: {Number} ");