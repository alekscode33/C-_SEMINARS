/*
Итерация №2. Работа в группах
Задача №7. Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Please enter the tree digit Number = ");
int Number = int.Parse(Console.ReadLine());

int a;
int b;

a = Number % 10;  // To take remainder of integer division
// b = Number / 10; // Integer division

Console.WriteLine("Last digit is Remainder of division");
Console.WriteLine("Reminder is " + Number + " divided by 10 -> " + a);
// Console.WriteLine("Result of integer division -> " + b + " ");