// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите размеры массива");
int line = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты");
int numLine = Convert.ToInt32(Console.ReadLine());
int numColumns = Convert.ToInt32(Console.ReadLine());
if (line >= numLine && columns >= numColumns)
    Console.WriteLine($"это -> {array[numLine - 1, numColumns - 1]}");
else
{
    Console.WriteLine("Такого элемента нет");
}