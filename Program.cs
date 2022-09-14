// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[ , ] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   //row 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");

          for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j] ,3},");
            // else Console.Write($"{matrix[i, j], 3} ");
        Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i,j] ,3}," : $"{matrix[i, j], 3}");

        }


        Console.WriteLine("]");
    }
}



void Poisk(int[,] matrix)

{
    Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] = a) Console.Write($"{a}");

            else Console.Write("Такого элемента нет");
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3,4,-9,9);
PrintMatrix(array2D);
Poisk(array2D);





