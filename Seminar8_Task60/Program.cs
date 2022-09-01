// Домашнее задание
// Семинар 8, Задача 58
// Задать две матрицы. Написать программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размер 1-ой  матрицы через слэш (строка/столбец):");
string matrixFirst = Console.ReadLine();
Console.WriteLine("Введите размер 2-ой  матрицы через слэш (строка/столбец):");
string matrixSecond = Console.ReadLine();

string [] matrix1str = matrixFirst.Split("/");
string [] matrix2str = matrixSecond.Split("/");

int [,] matrix1 = new int [Convert.ToInt32(matrix1str[0]), Convert.ToInt32(matrix1str[1])];
int [,] matrix2 = new int [Convert.ToInt32(matrix2str[0]), Convert.ToInt32(matrix2str[1])];

// int [,]  FillArray(int numberRow, int numberCol, int leftRange = 0, int rightRange = 10)
// {
//     int [,] array = new int [numberRow, numberCol];
//     Random rand = new Random();

//     for (int i = 0; i < numberRow; i++)
//     {
//         for (int j = 0; j < numberCol; j++)
//         {
//             array[i,j] = rand.Next(leftRange,rightRange);    
//         }
//     }
//     return array;
// }

int [,]  FillArray(int numberRow, int numberCol, int leftRange = 0, int rightRange = 10)
{
    int [,] array = new int [numberRow, numberCol];
    Random rand = new Random();

    for (int i = 0; i < numberRow; i++)
    {
        for (int j = 0; j < numberCol; j++)
        {
            Console.WriteLine($"Введите элемент: строка-{i}  столбец-{j}");
            array[i,j] = Convert.ToInt32(Console.ReadLine());    
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

int [,]  MultiplicateMatrix(int [,] mtrx1, int [,] mtrx2)
{
    int [,] auxArr = new int [mtrx1.GetLength(0), mtrx2.GetLength(1)*4];
    int [,] result = new int [mtrx1.GetLength(0), mtrx2.GetLength(1)];
    int idx = 0;
    for (int i = 0; i < mtrx2.GetLength(1)*4; i = i+2)
    {
        for (int j = 0; j < mtrx1.GetLength(0); j++)
        {
            auxArr[j,i] = mtrx1[j,idx];
        }
        if (idx == 0) idx = 1; 
        else idx = 0; 
    }

    int idxRow = 0; int idxCol = 0; int count = 0;
    for (int i = 1; i < mtrx2.GetLength(1)*4; i = i+2)
    {
        for (int j = 0; j < mtrx1.GetLength(0); j++)
        {
            auxArr[j,i] = mtrx2[idxRow, idxCol];
            //Console.WriteLine(count+ " Row-"+j +" Col-" +i+ " idxRow-"+idxRow +" idxCol-"+ idxCol);
        }
        count++;
        if (count%2 == 0) {idxRow = 0; idxCol++;} 
        else idxRow = 1; 
    }

    ArrayPrintOut(auxArr); Console.WriteLine();

    idx = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1)*4; j = j + 4)
        {
            result[i,idx] = auxArr[i,j]*auxArr[i,j+1] + auxArr[i,j+2]*auxArr[i,j+3];
            Console.WriteLine($"result[{i},{idx}]= {auxArr[i,j]}*{auxArr[i,j+1]} + {auxArr[i,j+2]}*{auxArr[i,j+3]}");
            idx++;
        }
        idx = 0;
    }

    return result;
}


matrix1 = FillArray(matrix1.GetLength(0), matrix1.GetLength(1),-10,11);
matrix2 = FillArray(matrix2.GetLength(0), matrix2.GetLength(1),-10,11);

ArrayPrintOut(MultiplicateMatrix(matrix1, matrix2));
Console.WriteLine();
ArrayPrintOut(matrix1); Console.WriteLine();
ArrayPrintOut(matrix2); Console.WriteLine();

