/* Задача 64:
     Задайте значения M и N. Напишите программу, которая выведет все 
     натуральные числа в промежутке от M до N.
     M = 1; N = 5. -> "1, 2, 3, 4, 5"
     M = 4; N = 8. -> "4, 6, 7, 8"
*/

void NumberFromMtoN(int m, int n)
{
    if (n > m) NumberFromMtoN(m, n - 1);
    System.Console.Write($"{n} ");
    if (m > n) NumberFromMtoN(m, n + 1);

}
NumberFromMtoN(4, 8);