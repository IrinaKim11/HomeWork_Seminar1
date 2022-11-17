//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4




Console.WriteLine("Введите номер строки: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine() ?? "0");


int[,] array = GetArray(4, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
GetPOsition(row,column);


void GetPOsition(int row, int column)
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine("Такой позиции нет ");
    }
    else
    {

        Console.WriteLine($"Значение элемента в таблице {array[row - 1, column - 1]}");
    }
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

void PrintArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i, j]} ");
        }
        Console.WriteLine();
    }
}

