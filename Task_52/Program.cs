/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

int[,] FillMatrixRndInt(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}
double SumAverage(int[,] array)
{
    double sumAverage = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumAverage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumAverage += (array[i, j]);
        }
        sumAverage /= array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое суммы элементов столбца {j + 1}: {Math.Round(sumAverage * 10, 2)} ");
    }
    return sumAverage;
}
Console.Write($"Пожалуйста, введите число строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Пожалуйста, введите число столбцов матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Исходный массив: ");
int[,] arrayRes = FillMatrixRndInt(row, col);
PrintMatrix(arrayRes);
double res = SumAverage(arrayRes);