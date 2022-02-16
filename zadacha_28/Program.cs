// Задача 28: Подсчитайте сумму цифр в числе
int number = new Random().Next(1, 1000000);
int number1 = number;
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine("Сумма цифр в числе " + number1 + " : " + sum);