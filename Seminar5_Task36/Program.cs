// Домашнее задание
// Семинар 5, Задача 36
// Генерация одномерного массива со случайными числами, нахождение суммы нечетных элементов массива

Console.WriteLine("Задайте количество элементов в массиве:");
int arrLength  = Convert.ToInt32(Console.ReadLine()) ;

int oddSum = 0;
int[] arr = new int [arrLength];
Random Rand = new Random();

for(int i = 0; i < arrLength; i++)
{
    arr[i] = Rand.Next(-500,500);
    if (i%2 == 1) oddSum+= arr[i];
}

Console.WriteLine("[" + string.Join(", ", arr) +"]");
Console.WriteLine($"Сумма нечетных элементов в массиве: {oddSum} ");