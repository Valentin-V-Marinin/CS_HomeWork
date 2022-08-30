// Домашнее задание
// Семинар 8, Задача 54
// Задать двумерный массив, упорядочить по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());

int [,] sourceArray = new int [numberRow, numberCol];

int [,]  FillArray(int numberRow, int numberColumn, int leftRange = 0, int rightRange = 10)
{
    int [,] array = new int [numberRow,numberCol];
    Random rand = new Random();

    for (int i = 0; i < numberRow; i++)
    {
        for (int j = 0; j < numberCol; j++)
        {
            array[i,j] = rand.Next(leftRange, rightRange);    
        }
    }
    return array;
}

void ArrayPrintOut(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,10}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int [,] array)
{
    int buffer = 0; bool sorted = true; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        do
        {
            for (int j = 0; j+1 < array.GetLength(1); j++)
            {
                sorted = true;
                if (array[i,j+1] > array[i,j]) 
                { 
                    buffer = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = buffer;
                    sorted = false; 
                    break;
                }
            }
        }    
        while (!(sorted));
    }
    return array; 
}

sourceArray = FillArray(numberRow, numberCol, -99, 100);
ArrayPrintOut(sourceArray);
Console.WriteLine();
ArrayPrintOut(SortArray(sourceArray));