 // Задача 2
// Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
/*
пример:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*

// Решение:

Console.Write("imput your 1st number: ");
int numBer_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput your 2st number: ");
int numBer_2 = Convert.ToInt32(Console.ReadLine());

if(numBer_1 > numBer_2)
{
    Console.WriteLine("Input numBer_1 = max, numBer_2 = min");
}
else
{
    Console.WriteLine("Input numBer_2 = max, numBer_1 = min");
}
*/

// Задача№4
// Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
/*
Пример:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Решение:

Console.Write("imput your 1st number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput your 2st number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput your 3st number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if(num_2 > num_1)
{
    Console.WriteLine("Input max = num_2");
}
else
{
    Console.WriteLine(" max = num_1");
}
if(num_3 > num_1)
{
    Console.WriteLine(" max = num_3");
}
else
{
    Console.WriteLine(" max = num_1");
}
