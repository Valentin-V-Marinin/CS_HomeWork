// Домашнее задание
// Семинар 7, Задача 52
// Задать двумерный массив из целых чисел. Найти среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[numberRow,numberCol];
int [] arraySumColumn = new int[numberCol];
int columnWidth = 6;

Random rand = new Random();

// заполняем массив случайными числами
for (int i = 0; i < numberRow; i++)
{
    for (int j = 0; j < numberCol; j++)
    {
        array[i,j] = rand.Next(-100,101);  
        arraySumColumn[j] += array[i,j];   
    }
}

// выводим массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,"+ columnWidth +"}", array[i, j]);
    }
    Console.WriteLine();
}

// резьтирующая линия
string s = new String('-', array.GetLength(1)*columnWidth);
Console.WriteLine(s);

// выводим среднее значение по столбцу
double avrColumn = 0;
for (int j = 0; j < arraySumColumn.Length; j++)
{
    avrColumn = Math.Round(Convert.ToDouble(arraySumColumn[j])/array.GetLength(0),1);
    Console.Write("{0,"+ columnWidth +"}", avrColumn);
}
Console.WriteLine();

