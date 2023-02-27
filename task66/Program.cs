// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M:");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите число N:");
int numN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GetNumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    GetNumberSum(numM, numN, sum);
}

GetNumberSum(numM, numN, 0);