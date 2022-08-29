﻿

double[,] FillArray(int numLine, int numColumns)    
{
    Random random = new Random();  
    double[,] matrix = new double[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    
        {
            matrix[i, j] = random.NextDouble()*30-10;      
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)              
{
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  
        {
            Console.Write("{0,8:F2}",matrix[i, j]);
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(5,5));