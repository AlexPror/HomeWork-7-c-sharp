/* Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет */

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

void FindElemThroughPos(int[,] array)
{
    Console.WriteLine($"Пожалуйста, введите номер позиции элемента для матрицы {array.GetLength(0)} х {array.GetLength(1)}: ");
    Console.Write("Введите номер строки элемента: ");
    int indexRow = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите номер столбца элемента: ");
    int indexCol = Convert.ToInt32(Console.ReadLine()) - 1;

    while (indexRow >= array.GetLength(0) || indexCol >= array.GetLength(1))
    {
        Console.WriteLine($"Введенные значения {indexRow + 1} и {indexCol + 1} выходят за границы. Введите еще раз.");
        Console.Write("Введите номер строки элемента: ");
        indexRow = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Введите номер столбца элемента: ");
        indexCol = Convert.ToInt32(Console.ReadLine()) - 1;
    }
    Console.Write($"Такой элемент есть : {array[indexRow, indexCol]}");
}

Console.Write($"Пожалуйста, введите число строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Пожалуйста, введите число столбцов матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] arrayRes = FillMatrixRndInt(row, col);
PrintMatrix(arrayRes);
FindElemThroughPos(arrayRes);