// Домашнее задание
// Семинар 7, Задача 50
// Приём на вход позиции элемента в двумерном массиве, и возврат значения этого элемента 
//   или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк массива:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int numberCol = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[numberRow,numberCol];
Random rand = new Random();

for (int i = 0; i < numberRow; i++)
{
    for (int j = 0; j < numberCol; j++)
    {
        array[i,j] = rand.Next(-200,201);    
    }
}

// Ввод индекса в формате 111 начиная с матрицы 12х12 будет неоднозначен,
// поэтому вводим индекс через слэш 

Console.WriteLine("Введите индекс элемента двумерного массива через слэш (строка/столбец):");
string index = string.Empty; index = Console.ReadLine();
string [] indexArray = index.Split("/");
int indexRow = Convert.ToInt32(indexArray[0]);
int indexColumn = Convert.ToInt32(indexArray[1]);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,5}", array[i, j]);
    }
    Console.WriteLine();
}

if (indexRow >= array.GetLength(0) || indexColumn >= array.GetLength(1))
    { Console.WriteLine($"Введённый индекс {index} за пределами массива."); }
else
    { Console.WriteLine($"Элемент массива с индексом {index} имеет значение {array[indexRow, indexColumn]}"); }
