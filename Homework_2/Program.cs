// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine() ?? "0");
if (numberA == numberB*numberB)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго");
}