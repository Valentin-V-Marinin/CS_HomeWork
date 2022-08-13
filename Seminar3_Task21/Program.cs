// Домашнее задание
// Семинар 3, Задача 21
// Приём на вход координат 2-х точек, вычисление расстояния между ними  

string[] Coordinates = {"X","Y","Z"};
int[] dotA = new int[3];
int[] dotB = new int[3];
int count1 = 1;
int count2 = 0;

// Ввод координат
while (count1 < 3)
{
    while (count2 < 3)
    {
        Console.WriteLine($"Введите {Coordinates[count2]}-координату  {count1}-ой точки ");
            if (count1 == 1)
                {   dotA[count2] = Convert.ToInt32(Console.ReadLine()); }
            else
                {   dotB[count2] = Convert.ToInt32(Console.ReadLine()); }
        count2++;
    }
    count2 = 0; count1++;
}

// Расчет расстояния
Console.WriteLine(
    "Расстояние между точками равно: " +
    Math.Sqrt(Math.Pow(dotA[0]-dotB[0],2) + Math.Pow(dotA[2]-dotB[2],2) + Math.Pow(dotA[1]-dotB[1],2))
);