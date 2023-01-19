Console.WriteLine("Введите первое число  ");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите второе число  ");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);

if(number1/number2 == number2)
{
    Console.WriteLine("Да, первое число является квадратом второго.");
}

else 
{
    Console.WriteLine("Нет, первое число не является квадратом второго.");
}