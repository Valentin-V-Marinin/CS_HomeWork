// Домашнее задание
// Семинар 3, Задача 23
// Вывод кубов чисел от 1 до введенного N

Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());

string MyCubes(int CountTo)
{
    int count = 1;
    string result = "";
    if (N > 0)
    {
        while (count <= CountTo)
        {
            result = result + Math.Pow(count,3) + ", ";
            count++;
        }
    }
    else
    {
        while (CountTo <= count)
        {
            result = result + Math.Pow(CountTo,3) + ", ";
            CountTo++;
        }
    }

    return result.TrimEnd(new char[] {',', ' '});
}

Console.WriteLine(MyCubes(N));



