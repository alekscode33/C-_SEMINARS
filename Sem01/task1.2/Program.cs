/*
Итерация №1:
Задача №3. Напишите программу, которая будет выдавать название
дня недели по заданному номеру. Например: 
3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("Please input the number from 1 to 7 ");
int WeekDay = int.Parse(Console.ReadLine());
// WeekDay - Day of the week Returns the day
// of the week corresponding to a date
if (WeekDay == 1)
{
    Console.WriteLine(" -> Monday");
}
if (WeekDay == 2)
{
    Console.WriteLine(" -> Tuesday");
}
if (WeekDay == 3)
{
    Console.WriteLine(" -> Wednesday");
}
if (WeekDay == 4)
{
    Console.WriteLine(" -> Thursday");
}
if (WeekDay == 5)
{
    Console.WriteLine(" -> Friday");
}
if (WeekDay == 6)
{
    Console.WriteLine(" -> Saturday");
}
if (WeekDay == 7)
{
    Console.WriteLine(" -> Sunday");
}
else
{
    Console.WriteLine(" -> Wrong Number");
}