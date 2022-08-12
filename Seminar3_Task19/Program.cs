// Домашнее задание
// Семинар 3, Задача 19
// Ввод 5-тизначного числа и определение наличия палиндрома  

Console.WriteLine("Введите 5-тизначное число:");
int Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (Number >9999 && Number <100000)
{
    string NumberS = Convert.ToString(Number);
    if (NumberS[0] == NumberS[4] && NumberS[1] == NumberS[3])
    {
        Console.WriteLine($" {Number} - это число-палиндром.");
    }
    else
    {
        Console.WriteLine($" {Number} - это число НЕ палиндром.");
    }
}
else
{
    Console.WriteLine($"Введённое число {Number} не пятизначное!");
}