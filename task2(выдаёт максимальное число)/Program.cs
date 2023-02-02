// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine()); 

// Лучше делать так:

int max = numA;

if (numB > max) max = numB;
if (numC > max) max = numC;
Console.WriteLine("max = ");
Console.WriteLine(max);

//if (numA > numB && numA > numC)
{
    Console.WriteLine("Максимальное число: " + numA);
}
//if (numB > numA && numB > numC)
{
    Console.WriteLine("Максимальное число: " + numB);
}
//if (numC > numB && numC > numA)
{
    Console.WriteLine("Максимальное число: " + numC);
}