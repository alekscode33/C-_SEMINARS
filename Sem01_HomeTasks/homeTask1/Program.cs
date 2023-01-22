/* 
Home tasks 1
Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Please enter a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Please enter b = ");
int b = int.Parse(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
    Console.WriteLine(" b is a max = " + max);
}
else
{
    Console.WriteLine(" a is max = " + max);
}