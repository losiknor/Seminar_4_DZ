// Задача 26: Возведите число А в натуральную степень B, используя цикл.
int num = new Random().Next(2, 10);
int deg = new Random().Next(2, 10);
Console.WriteLine("Результат возведения " + num + " в степень " + deg +" : ");
int exp = 1;
for (int i = 1; i <= deg; i++)
exp = exp * num;
Console.Write(exp);
