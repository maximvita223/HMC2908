Console.WriteLine("Введите колличество строк и столбцов");
int numLine = Convert.ToInt32(Console.ReadLine());
int numColumns = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }

    int summa = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summa += matrix[j, i];
        }
        Console.Write($"Среднее арифмитическое столбца {i + 1} = {(float)summa / matrix.GetLength(0):F2}");
        summa = 0;
    }
    

