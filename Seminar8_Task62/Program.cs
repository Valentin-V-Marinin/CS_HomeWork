// Домашнее задание
// Семинар 8, Задача 62
//  Написать программу, которая заполнит спирально массив 4 на 4

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [numberRow, numberCol];
int valueArray = 1;

void ArrayPrintOut(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

bool MoveRight(bool end, int [,] arr, ref int i, ref int j, ref int valueArray)
{
    end = true;
    while (j >= 0 & j <= arr.GetLength(1)-1)
    {
        if (arr[i,j] != 0) break;
        {arr[i,j] = valueArray++; j++; end = false;} 
    }
    i++; j--;
    return end;
}

bool MoveDown(bool end, int [,] arr, ref int i, ref int j, ref int valueArray)
{
    end = true;
    while (i >= 0 & i <= arr.GetLength(0)-1)
    {
        if (arr[i,j] != 0) break;
        {arr[i,j] = valueArray++; i++; end = false;}
    }
    i--; j--;
    return end;
}

bool MoveLeft(bool end, int [,] arr, ref int i, ref int j, ref int valueArray)
{
    end = true;
    while (j >= 0 & j <= arr.GetLength(1)-1)
    {
        if (arr[i,j] != 0) break;
        {arr[i,j] = valueArray++; j--; end = false;} 
    }
    i--; j++;
    return end;
}

bool MoveUp(bool end, int [,] arr, ref int i, ref int j, ref int valueArray)
{
    end = true;
    while (i >= 0 & i <= arr.GetLength(0)-1)
    {
        if (arr[i,j] != 0) break;
        {arr[i,j] = valueArray++; i--; end = false;}
    }
    i++; j++;
    return end;
}

bool endProgram = false;
int currPositionI = 0; int currPositionJ = 0; 

do
{
    endProgram = MoveRight(endProgram, array, ref currPositionI, ref currPositionJ, ref valueArray);
    endProgram = MoveDown(endProgram, array, ref currPositionI, ref currPositionJ, ref valueArray);
    endProgram = MoveLeft(endProgram, array, ref currPositionI, ref currPositionJ, ref valueArray);
    endProgram = MoveUp(endProgram, array, ref currPositionI, ref currPositionJ, ref valueArray);
} while (!endProgram);

ArrayPrintOut(array);
