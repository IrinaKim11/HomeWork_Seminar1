// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите натуральную степень: ");
int numberB = int.Parse (Console.ReadLine() ?? "0");
int deg = GetDegNums(numberA);
Console.Write($"Число {numberA} в степени {numberB} = {deg}");

int GetDegNums(int numberA)
{
    int deg = numberA;
    int count = 1;
    while(count<numberB)
    {
        deg = deg * numberA;
        count++;
        Console.WriteLine($"{deg}");
    }
return deg;
}