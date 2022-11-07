//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(в примере показаны два разных массива, создаем именно для 8 элементов)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]




void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next();
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
        if(position < count)
        {
            Console.Write(", ");
        }
    }
     Console.Write("]");
}




int []array = new int[8];
FillArray(array);
PrintArray(array);
