/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Write("Please enter a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Please enter b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("Please enter c = ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
    Console.WriteLine(" b is max = " + max);
}
else if (c > max)
{
    max = c;
    Console.WriteLine(" c is max = " + max);
}
else
{
    Console.WriteLine(" a is max = " + max);
}



