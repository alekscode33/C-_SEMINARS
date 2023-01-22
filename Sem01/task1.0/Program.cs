// Задача: 
// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число умноженное на само себя). Например: 
//  ● 4-> 16
//  ● -3-> 9
//  ● -7-> 49

Console.WriteLine("Need to find the square of the entered number: ");
Console.WriteLine("Please, input any integer number");
int number = int.Parse(Console.ReadLine()); // Pars - встроенный метод
                                            // который парсит строку переводит ее 
                                            // в числовое значение 

int sqNum = number * number;     //  sqNum is the square number 
                                 // or the number multiplied by itself.

Console.WriteLine("Square number: sqNum = number * number = " + sqNum);        // WriteLine — это вывод с переходом на новую строку. 
