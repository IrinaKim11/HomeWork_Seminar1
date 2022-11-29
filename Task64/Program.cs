//Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.


Console.Clear();

void PrintNumbers(int min, int max)
{
    if (min == max && max % 2 == 0)
    {
        Console.Write("{0, 4}", max);
        return;
    }
    else if (max % 2 == 0)
    {
        Console.Write("{0, 4}", max);
    }
    PrintNumbers(min, max - 1);
}

Console.WriteLine("Введите число: ");
int max = int.Parse(Console.ReadLine()!);
PrintNumbers(2, max);