// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2; 

if (number > 100)
{
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine("третья цифра  числа " + number + " это " + digit);
}
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}