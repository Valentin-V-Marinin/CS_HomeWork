// Домашнее задание
// Семинар 5, Задача 38
// Ввод массива с вещественными числами, нахождение разности между максимальным и минимальным элементами массива

Console.WriteLine("Cколько элементов будет в массиве?:");
int arrLength = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[arrLength];
double min = 0, max = 0;

for(int i = 0; i < arrLength; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива:");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    if (i == 0) {min = arr[i]; max = arr[i];}
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
}

Console.WriteLine("[" + string.Join(", ", arr) +"]");
Console.WriteLine($"Наибольший элемент массива: {max},  наименьший: {min},  разность: {max-min} ");