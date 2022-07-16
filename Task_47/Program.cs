/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();

double[,] FillMatrixRndDouble(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + "\t");
            else Console.Write(array[i, j] + " ]");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arrayResult = FillMatrixRndDouble(m, n);
PrintMatrix(arrayResult);