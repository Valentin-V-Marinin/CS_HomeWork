// Домашнее задание
// Семинар 6, Задача 41.1
// Ввод М чисел с клавиатуры, нахождение количества введённых чисел больше нуля

Console.WriteLine("Ввод чисел для сравнения прерывается вводом латинской буквы 'X'.");

string number = string.Empty;
string numberArray = string.Empty;
int count = 0;
int positiveNumber = 0;

do
{
    Console.WriteLine($"Введите {++count}-е число");
    number = Console.ReadLine();
    numberArray += number + "|";
}
while (number.ToUpper() != "X");

count--; // уменьшаем счетчик, чтобы финальный 'x' не попадал в расчет
string [] stringArrNumber = numberArray.Split("|");
int [] arrayNumbers = new int[count];

for (int i = 0; i < count; i++)
{
    arrayNumbers[i] = Convert.ToInt32(stringArrNumber[i]);
    if (arrayNumbers[i] > 0) positiveNumber++;
}

Console.WriteLine(string.Join(", ", arrayNumbers));
Console.WriteLine($"Количество чисел больше нуля: {positiveNumber}");



