// Задача 32: Задайте массив из восьми элементов, заполненных нулями 
// и единицами. Выведите их на экран
int[] array = new int[8];
Random rnd1 = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd1.Next(0, 2);
    Console.Write(array[i] + " ");
}