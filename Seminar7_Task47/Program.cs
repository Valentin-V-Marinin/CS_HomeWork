// Домашнее задание
// Семинар 7, Задача 47
// Задать двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [numberRow,numberCol];
Random rand = new Random();

for (int i = 0; i < numberRow; i++)
{
    for (int j = 0; j < numberCol; j++)
    {
        array[i,j] = rand.Next(-200,201) + Math.Round(rand.NextDouble(),3);    
    }
}
 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,10}", array[i, j]);
    }
    Console.WriteLine();
}
