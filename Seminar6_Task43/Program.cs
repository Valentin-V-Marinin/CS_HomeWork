// Домашнее задание
// Семинар 6, Задача 43
// Найти точку пересечения 2-х прямых заданных уравнениями

Console.WriteLine("Ввод коэффициентов 2-х линейных уравнений");

double k1 = 0, b1 = 0, k2 = 0, b2 = 0;
Console.WriteLine("Введите коэффициент k1");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
b2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2 & b1!=b2) Console.WriteLine("Прямые параллельны.");   
if (k1==k2 & b1==b2) Console.WriteLine("Прямые совпадают.");
if (k1!=k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = Math.Round(k1*x + b1,1);
    Console.WriteLine($"координаты точки пересечения 2-х заданных прямых: x={x}, y={y}.");
}   

