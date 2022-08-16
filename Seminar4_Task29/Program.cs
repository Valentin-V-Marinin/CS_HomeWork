// Домашнее задание
// Семинар 4, Задача 29
// Приём на вход массива из 8 элементов, вывод массива 


int[] array = new int[8];

// заполняем массив
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Полученный массив: [" + String.Join(" ,", array) + "]");


