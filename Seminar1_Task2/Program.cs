// Домашнее задание
// Семинар 1, Задача 2
// Определение большего и меньшего из 2-х чисел

Console.WriteLine("Введите первое число для сравнения : ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения : ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
    {
        Console.WriteLine("При сравнении 2-х чисел: " + FirstNumber +" и " + SecondNumber +
                          ", большим является: " + FirstNumber +
                          ", меньшим является: " + SecondNumber);
    }
else if (FirstNumber < SecondNumber)
    {
        Console.WriteLine("При сравнении 2-х чисел: " + FirstNumber +" и " + SecondNumber + 
                          ", большим является: " + SecondNumber +
                          ", меньшим является: " + FirstNumber);
    }
else 
    {
        Console.WriteLine("При сравнении 2-х чисел: " + FirstNumber +" и " + SecondNumber + ", выявлено их равенство.");
    }

