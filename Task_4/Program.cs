// Напишите программу, которая на вход принимает одно число N а на выход выдает все целые числа от -N до N

Console.WriteLine("Введите число N  ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

for (int i = -number; i <= number; i++)
{
Console.WriteLine(i);
}