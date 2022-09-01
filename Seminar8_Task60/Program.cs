// Домашнее задание
// Семинар 8, Задача 60
// Сформировать трёхмерный массив размером 2 x 2 x 2 из неповторяющихся двузначных чисел. 
// Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int [,,] array3d = new int [2,2,2];


int [,,]  FillArray3d(int numberRow, int numberCol, int numberDepth, int leftRange = 0, int rightRange = 10)
{
    int [,,] array = new int [numberRow, numberCol, numberDepth];

    for (int z = 0; z < numberDepth; z++)
    {
        for (int i = 0; i < numberRow; i++)
        {
            for (int j = 0; j < numberCol; j++)
            {
                Console.WriteLine($"Введите элемент: глубина-{z} строка-{i}  столбец-{j}");
                array[z,i,j] = Convert.ToInt32(Console.ReadLine());    
            }
        }
    }
    return array;
}


void Array3dPrintOut(int [,,] array)
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,10}", array[z, i, j] + $"({z},{i},{j})");
            }
            Console.WriteLine();
        }
    }
}

Array3dPrintOut(FillArray3d(2,2,2,-99,100));
Console.WriteLine();
