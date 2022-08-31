// Домашнее задание
// Семинар 8, Задача 56
// Задать прямоугольный двумерный массив, найти строку с наименьшей суммой элементов.

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
            array[i,j] = rand.Next(leftRange,rightRange);    
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

(int sumMinimum, int idxRowMin, int count, int [] sum, string idxList) FindSumMinimum(int [,] array)
{
    int [] sum = new int [array.GetLength(0)];
    int sumMinimum = 0; int idxRowMinimum = 0; int count = 0; string idxList = string.Empty;
    (int sumMinimum, int idxRowMin, int count, int [] sum, string idxList) result = new (sumMinimum, idxRowMinimum, count, sum, idxList);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
        if (i == 0)
            {
                result.sumMinimum = sum[i];
                result.idxRowMin = i+1;
                result.idxList = Convert.ToString(i+1);
                result.count = 1;
                Console.WriteLine("i=0      " + i + " " + result.count + " " + result.idxList + " " + result.idxRowMin + " " + result.sumMinimum);
            }
        if (i > 0)
            {
                if (sum[i] == result.sumMinimum)
                {
                    result.idxList += ", " + Convert.ToString(i+1);
                    result.count++;
                    Console.WriteLine("i>0 =min " + i + " " + result.count + " " + result.idxList + " " + result.idxRowMin + " " + result.sumMinimum);
                } 
                if (sum[i] < result.sumMinimum) 
                {
                    result.sumMinimum = sum[i]; 
                    result.idxRowMin = i+1;
                    result.idxList = Convert.ToString(i+1);
                    result.count = 1;
                    Console.WriteLine("i>0 <min " + i + " " + result.count + " " + result.idxList + " " + result.idxRowMin + " " + result.sumMinimum);
                } 
            }
    }
    return result;
}

sourceArray = FillArray(numberRow, numberCol, -10, 11);
ArrayPrintOut(sourceArray);
Console.WriteLine();
(int sumMinimum, int idxRowMin, int count, int [] sum, string idxList) resultFunc = FindSumMinimum(sourceArray);

if (resultFunc.count == 1)
    { Console.WriteLine($"Строка №{resultFunc.idxRowMin} имеет минимальную сумму элементов ({resultFunc.sumMinimum})."); }
else
    { Console.WriteLine($"Строки №№ {resultFunc.idxList} имеют минимальную сумму элементов ({resultFunc.sumMinimum})."); }

Console.WriteLine("Суммы строк в порядке возрастания номера строки: " + string.Join(", ", resultFunc.sum));
Console.WriteLine();
Console.WriteLine(resultFunc.count + " " + resultFunc.idxList);
Console.WriteLine();