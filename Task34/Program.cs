// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int[] array = GetArray(7,100,999);
PrintArray(array);

int count = 0;

foreach(int el in array)

{
    if(el%2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.Write($"В заданном массиве количество четных чисел = {count}");