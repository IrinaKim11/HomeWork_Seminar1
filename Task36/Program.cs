// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void GetSum(int[] mass)
{
 int sum=0;
for(int i = 0; i<mass.Length;i++)
{
    int k = mass [i];
    if(i%2!=0)
    {
        sum = sum+k;
        
    }
}
Console.Write($"сумма элементов, стоящих на нечётных позициях = {sum} ");
}



int[] array = GetArray(4,0,10);
PrintArray(array);
Console.WriteLine();
GetSum(array);
Console.WriteLine();