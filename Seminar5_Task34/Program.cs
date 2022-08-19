// Домашнее задание
// Семинар 5, Задача 34
// Генерация массива с трехзначными положительными числами,
//   вывод количества четных чисел в массиве

Console.WriteLine("Введите количество элементов в массиве: ");
int arrLength  = Convert.ToInt32(Console.ReadLine()) ;

int evenNumber = 0;
int[] arr = new int [arrLength];
Random Rand = new Random();

for(int i = 0; i < arrLength; i++)
{
    arr[i] = Rand.Next(100,1000);
    if (arr[i]%2 == 0) evenNumber+= 1;
}

Console.WriteLine("[" + string.Join(", ", arr) +"]");
Console.WriteLine($"Количество четных чисел в массиве: {evenNumber} ");
