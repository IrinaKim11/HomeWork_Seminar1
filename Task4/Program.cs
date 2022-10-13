// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse (Console.ReadLine());
int max = numberA;

if(max < numberB)
{
    max = numberB;
}
if(max < numberC)
{
    max = numberC;
}
    Console.WriteLine($"Наибольшее число: {max}");
