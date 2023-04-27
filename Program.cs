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
/*
Console.Write("imput your 1st number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput your 2st number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput your 3st number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if(max < num_2) max = num_2;


if(max < num_3) max = num_3;

Console.WriteLine("max = " + max);
*/

// Задача№6
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
   Пример:
   4 -> да
  -3 -> нет
   7 -> нет
*/

// Решение:
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

 if(number%2 == 0)
{
    Console.WriteLine(number + " -> yes ");
}
else
{
    Console.WriteLine(number + " -> no");
}
*/

// Задача№8
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
   Пример:
  5 -> 2, 4
  8 -> 2, 4, 6, 8
*/
// Решение:
/*
Console.Write("Input your number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

for(int current_i = 1;current_i <= number_N; current_i++)
{
    if (current_i % 2 == 0)
    {
        Console.Write(current_i + ", ");
    }
}
*/
