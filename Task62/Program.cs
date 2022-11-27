// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int size = 4;
int[,] array = new int[size, size];
SpiralMatrix(array, size);
PrintArray(array);

void SpiralMatrix(int[,] array, int size)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= size * size)
    {
        array[i, j] = temp;

        if (i <= j + 1 && i + j < size - 1) 
            j++;

        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        ++temp;
    }

}




void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

