// Домашнее задание
// Семинар 6, Задача 45
// Получить копию заданного массива с помощью поэлементного копирования

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());

int [,] givenArray = new int [numberRow,numberCol];
int [,] replicaArray = new int [numberRow,numberCol];
Random rand = new Random();

for (int i = 0; i < numberRow; i++)
{
    for (int j = 0; j < numberCol; j++)
    {
        givenArray[i,j] = rand.Next(-100,101);    
    }
}

for (int i = 0; i < numberRow; i++)
{
    for (int j = 0; j < numberCol; j++)
    {
        replicaArray[i,j] = givenArray[i,j];    
    }
}

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Исходный массив:");
ArrayPrint(givenArray);
Console.WriteLine();
Console.WriteLine("Резервный массив:");
ArrayPrint(replicaArray);

