// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел от 1 до 20, заканчивающиеся на чётную цифру: ");
for (int i = 1; i <= 20; i++)
{
    double res = Math.Pow(i, 3);
    if ((res % 10) % 2 == 0)
        Console.WriteLine(res);

}

