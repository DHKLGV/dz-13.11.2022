// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = (Console.ReadLine());
int num = number.Length;
if (num >= 3)
{
    Console.WriteLine($"Третье число: {number[2]} ");
}
else
{
    Console.WriteLine($"третьей цифры нет");
}