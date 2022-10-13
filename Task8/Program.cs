// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите положительное число: ");
int numberA = int.Parse (Console.ReadLine());
int numberB = 2;
while(numberB <= numberA)
{
    Console.Write($" { numberB } ");
    numberB = numberB + 2;
}