// Домашнее задание
// Семинар 4, Задача 28*
// Приём на вход массива с числами, вывод массива с факториалами этих чисел 

// На входе просим определить размер массива - количество элементов массива
// Исходный массив заполняем функцией случайных чисел

Console.WriteLine("Введите размер массива:");
int ArrayNumber = Convert.ToInt32(Console.ReadLine());

int[] array_source = new int[ArrayNumber];
int[] array_result = new int[ArrayNumber];

// определяем функцию расчета факториала
int Factorial(int Fctr)
{
    int f_result = 1;
    for (int i = 1; i <= Fctr; i++)
    {
        f_result *= i;
    }
    return f_result;
}

// заполняем массивы
for (int i = 0; i < ArrayNumber; i++)
{
    array_source[i] = new Random().Next(0, 10);
    array_result[i] = Factorial(array_source[i]);
}

Console.WriteLine("Исходный массив: [" + String.Join(" ,", array_source) + "]");
Console.WriteLine("Расчетный массив: [" + String.Join(" ,", array_result) + "]");