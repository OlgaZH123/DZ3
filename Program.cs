// Задача 1
Console.WriteLine("Показать вторую цифру трехначного числа:");
int num = new Random().Next(100, 1000);
int secondNumber = num / 10%10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");

// Задача 2
Console.WriteLine("Найти третью цифру числа или сообщить, что ее нет:");
Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
if (num1<100)
{
    Console.WriteLine($"Третьей цифры нет");
}
if (num1 >= 100 && num1 <= 999)
{
    int thirdNumber = num1%10;
    Console.WriteLine($"Третьей цифра числа {num1} -> {thirdNumber}");
}
if (num1 >= 1000 && num1 <= 9999)
{
    int thirdNumber = (num1%100)/10;
    Console.WriteLine($"Третьей цифра числа {num1} -> {thirdNumber}");
}
if (num1 >= 10000 && num1 <= 100000)
{
    int thirdNumber = (num1%1000)/100;
    Console.WriteLine($"Третьей цифра числа {num1} -> {thirdNumber}");
}
if (num1 > 100000)
{
    Console.WriteLine($"Число введено неверно");
}

// Задача 3
Console.WriteLine("Дано число обозначающее день недели. Выяснить. является номер дня недели выходным:");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if ((number>7)|| (number<1))
{
    Console.WriteLine("Неверный день недели");
    return;
}
if ((number>5))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
