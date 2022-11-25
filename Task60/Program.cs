// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[2,2,2];
GetArray(array);
PrintArray(array);
Console.WriteLine();



void GetArray(int[,,] array)
{
    int[] temp = new int[array.Length];
    int number;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10,100);
        number=temp[i];
        if (i>=1)
        {
            for (int j = 0; j < i; j++)
            {
                while(temp[i]==temp[j])
                {
                    temp[i] = new Random().Next(10,100);
                    j=0;
                    number=temp[i];
                }
                number=temp[i];
            }
            
        }
    }
    int count = 0;
    for(int x = 0; x<array.GetLength(0); x++)
    {
        for(int y = 0; y<array.GetLength(1); y++)
        {
            for(int z = 0; z<array.GetLength(2); z++)
            {
                array[x,y,z] = temp[count];
                count++;
            }
        }
    }
    
}


void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
    //   Console.Write($"({i},{j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]} ({j},{k},{i})\t");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
