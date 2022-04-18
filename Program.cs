
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*

Console.Write("Input the first of the two numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second of the two numbers: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Max number is " + num1);
    Console.WriteLine("Min number is " + num2);
}
else
{
    Console.WriteLine("Max number is " + num2);
    Console.WriteLine("Min number is " + num1);
}

*/

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write("Input the first of the three numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second of the three numbers: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the last of the three numbers: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
if (num1 > num3)
    Console.WriteLine("Max number is " + num1);
else
{
    if (num2 < num3)
    Console.WriteLine("Max number is " + num3);
}
else
{
    if (num1 < num2)
    if (num3 > num2)
    Console.WriteLine("Max number is " + num3);
}

*/

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).            

/*

Console.Write("Input integer: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Integer is even");
else
{
Console.WriteLine("Integer is uneven");
}

*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.




Console.Write("Input positive integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 0)
    Console.WriteLine("I sad - POSITIVE!!!)");

if (N % 2 == 0)
    
    Console.Write(N + " ");
    N++;

