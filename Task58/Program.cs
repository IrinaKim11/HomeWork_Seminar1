// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Console.Write("Введите количество строк первой матрицы: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int columnsA = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rowsA, columnsA, 0, 10);
PrintArray(array1);
Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int columnsB = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(rowsB, columnsB, 1, 10);
PrintArray(array2);
Console.WriteLine();

int[,] array3 = GetMultiply(array1, array2);
Console.Write("Произведение двух матриц равно");
Console.WriteLine();
PrintArray(array3);
// Console.WriteLine($"Произведение двух матриц равно: {GetMultiply(array1,array2)}");

if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы перемножать нельзя");
    return;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] GetMultiply(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}