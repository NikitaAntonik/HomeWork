// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 7 -> да
// 6 -> да
// 1 -> нет


Console.Write("Ваведите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 6 && num <= 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
