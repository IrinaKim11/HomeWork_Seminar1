// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine());

double[,] arr = Getarr(rows, columns, 0,10);
Printarr(arr);

double[,] Getarr(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return result;
}

void Printarr(double[,] inarr)
{
    for(int i = 0; i<inarr.GetLength(0); i++)
    {
        for(int j = 0; j<inarr.GetLength(1); j++)
        {
            Console.Write($"{inarr[i, j]} ");
        }
        Console.WriteLine();
    }
}