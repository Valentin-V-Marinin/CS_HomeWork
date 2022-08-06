// Домашнее задание
// Семинар 1, Задача 4
// Поиск максимального числа из 3-х введенных чисел

int max = 0;
int inputNumber = 0;
int count = 1;

while (count < 4)
    {
        Console.WriteLine("введите число №" + count);
        
        if (count == 1)
        {
            max = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > max) max = inputNumber;
        }
                
        count++;
    }
 
Console.WriteLine("максимальное число: " + max);