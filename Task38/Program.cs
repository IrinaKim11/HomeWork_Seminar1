// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int[] array = GetArray(7,1,10);
PrintArray(array);
Console.WriteLine();

int max = array[0];
int min = array[0];
for(int i = 0; i<array.Length;i++)
    {
        if(array[i]> max) max = array[i];
        if(array[i]< min) min = array[i];
        
    }
    Console.WriteLine(max-min);


// GetDiff(array);