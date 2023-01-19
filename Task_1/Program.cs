/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

то что мы вводим с консоли всегда будет тип string
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine() ?? String.Empty;
int number = Convert.ToInt32(numberStr);

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");
//Console.WriteLine("Квадрат числа" + number + "=" + result);
//Console.WriteLine("Квадрат числа {0} = {1}", number, result);