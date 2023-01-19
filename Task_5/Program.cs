// Напишите программу которая на вход принимает трехзначное число и на выходе выдает последнюю цифру этого числа

Console.WriteLine("Введите любое трехзначное число  ");
int number = Int32.Parse(Console.ReadLine());
if(number > 999 && number < 100)
{
    Console.WriteLine("Введен неправильный номер. Введите любое трехзначное число  ");
    return;
}

int result = number % 10;
Console.WriteLine(result);
